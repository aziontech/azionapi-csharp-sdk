import { execFile } from 'node:child_process'
import { existsSync, readFileSync, readdirSync } from 'node:fs'
import { createServer, type IncomingMessage, type Server } from 'node:http'
import type { AddressInfo } from 'node:net'
import path from 'node:path'
import { promisify } from 'node:util'
import { afterAll, beforeAll, describe, expect, it } from 'vitest'
import { BUILD, PACKAGES, ROOT, isGenericHost, output } from '../src'

const run = promisify(execFile)
const DOTNET = process.env.DOTNET_BIN ?? 'dotnet'

async function probe(pkg: string, mode: string, ...args: string[]) {
  const { stdout } = await run(DOTNET, [path.join(BUILD, 'probe', 'Probe.dll'), mode, output(pkg), ...args], { maxBuffer: 16 * 1024 * 1024 })
  return JSON.parse(stdout)
}

// Placeholders the probe uses for path parameters, mapped back to a generic "{param}".
function normalize(route: string): string {
  return decodeURIComponent(route)
    .replace(/__P\d+__/g, '{param}')
    .replace(/00000000-0000-0000-0000-\d{12}/g, '{param}')
    .replace(/\b900\d{3}\b/g, '{param}')
    .replace(/\{[^}]+\}/g, '{param}')
}

interface Endpoint { className: string; name: string; method: string; route: string }

// Endpoint table of the package README: *ApiClass* | [**Operation**](...) | **VERB** /path | ...
function documentedEndpoints(pkg: string): Endpoint[] {
  const readme = readFileSync(path.join(ROOT, pkg, 'README.md'), 'utf8')
  return [...readme.matchAll(/^\*(\w+)\* \| \[\*\*(\w+)\*\*\]\([^)]*\) \| \*\*(\w+)\*\* (\S+) \|/gm)].map(
    ([, className, name, method, route]) => ({ className, name, method, route }),
  )
}

// generichost packages document their endpoints in docs/apis/<ApiClass>.md instead.
function documentedGenericHostEndpoints(pkg: string): Endpoint[] {
  const dir = path.join(ROOT, pkg, 'docs', 'apis')
  return readdirSync(dir).flatMap((f) =>
    [...readFileSync(path.join(dir, f), 'utf8').matchAll(/^\| \[\*\*(\w+)\*\*\]\([^)]*\) \| \*\*(\w+)\*\* (\S+) \|/gm)].map(
      ([, name, method, route]) => ({ className: f.replace(/\.md$/, ''), name, method, route }),
    ),
  )
}

// Generated packages that do not compile today. Pinned with the compiler error so the
// suite fails once a regeneration fixes them (and the entry must be removed).
const KNOWN_BROKEN: Record<string, RegExp> = {
  // Model/PostCustomDataStreamingResponse.cs: a multi-line <example> doc comment leaves
  // "</example>" outside the /// comment.
  data_streaming: /PostCustomDataStreamingResponse\.cs\(\d+,\d+\): error CS1519/,
  // Model/DomainDataDigitalCertificateId.cs: invalid generated syntax in a oneOf wrapper.
  domains: /DomainDataDigitalCertificateId\.cs\(\d+,\d+\): error CS1003/,
  // Model/S3Credential*.cs: string length validation generated for DateTime properties.
  storage: /S3Credential(Create)?\.cs\(\d+,\d+\): error CS1061: 'DateTime' does not contain a definition for 'Length'/,
  // generichost packages still carry RestSharp/Newtonsoft client files from an older
  // generation, which their project no longer references.
  edgeapplications: /Client\/ApiClient\.cs\(\d+,\d+\): error CS0246: The type or namespace name 'RestSharp'/,
  edgefunctions: /Client\/ApiClient\.cs\(\d+,\d+\): error CS0246: The type or namespace name 'RestSharp'/,
}

// API classes left in the source tree by an older generation: they compile but are no
// longer in the package README. Pinned so that their removal, or a new undocumented
// class, makes the suite fail.
const KNOWN_UNDOCUMENTED: Record<string, string[]> = {
  variables: ['ApiApi'],
}

const results = (): Record<string, { ok: boolean; log: string }> =>
  JSON.parse(readFileSync(path.join(BUILD, 'results.json'), 'utf8'))

const key = (e: Endpoint) => `${e.className}.${e.name} ${e.method} ${normalize(e.route)}`

describe('generated packages', () => {
  it('finds every package of the SDK', () => {
    expect(PACKAGES.length).toBeGreaterThanOrEqual(18)
  })

  describe.each(PACKAGES)('%s', (pkg) => {
    it('builds from its own project file', () => {
      const result = results()[pkg]
      if (KNOWN_BROKEN[pkg]) {
        expect(result.ok).toBe(false)
        expect(result.log).toMatch(KNOWN_BROKEN[pkg])
      } else {
        expect(result.ok, result.log).toBe(true)
        expect(existsSync(output(pkg))).toBe(true)
      }
    })

    if (!isGenericHost(pkg) && !KNOWN_BROKEN[pkg]) it('sends every documented endpoint with the right HTTP verb and route', async () => {
      const documented = documentedEndpoints(pkg)
      expect(documented.length).toBeGreaterThan(0)
      const documentedClasses = new Set(documented.map((e) => e.className))
      const { basePath, routes: all } = await probe(pkg, 'routes')
      const undocumented = [...new Set((all as Endpoint[]).map((r) => r.className))].filter((c) => !documentedClasses.has(c))
      expect(undocumented.sort()).toEqual(KNOWN_UNDOCUMENTED[pkg] ?? [])
      const routes = (all as Endpoint[]).filter((r) => documentedClasses.has(r.className))
      expect(basePath).toMatch(/^https?:\/\//)
      for (const r of routes as unknown as { error: string | null; className: string; name: string }[]) expect(r.error, `${r.className}.${r.name}`).toBeNull()
      const prefix = new URL(basePath).pathname.replace(/\/$/, '')
      const generated = (routes as unknown as { className: string; name: string; method: string; path: string }[]).map((r) =>
        key({ className: r.className, name: r.name, method: r.method, route: r.path.slice(prefix.length) }),
      )
      expect(generated.sort()).toEqual(documented.map(key).sort())
    })

    // generichost packages are built through dependency injection; check the generated
    // client declares each documented route and verb.
    if (isGenericHost(pkg)) it('declares every documented endpoint in the generated client', () => {
      const apiDir = path.join(ROOT, pkg, 'src', pkg, 'Api')
      const sources = readdirSync(apiDir).map((f) => readFileSync(path.join(apiDir, f), 'utf8')).join('\n')
      const documented = documentedGenericHostEndpoints(pkg)
      expect(documented.length).toBeGreaterThan(0)
      for (const e of documented) {
        expect(sources, key(e)).toContain(`"${e.route}"`)
        expect(sources, key(e)).toMatch(new RegExp(`Task<I${e.name}ApiResponse> ${e.name}Async\\(`))
        expect(sources, key(e)).toMatch(new RegExp(`HttpMethod\\.${e.method[0]}${e.method.slice(1).toLowerCase()}|new HttpMethod\\("${e.method}"\\)`))
      }
    })
  })
})

interface Captured { method: string; url: string; headers: IncomingMessage['headers']; body: string }

describe('HTTP round trip against a local API double', () => {
  let server: Server
  let baseUrl: string
  const captured: Captured[] = []
  const responses = new Map<string, { status: number; body: unknown }>()

  beforeAll(async () => {
    server = createServer((req, res) => {
      let body = ''
      req.on('data', (chunk) => (body += chunk))
      req.on('end', () => {
        captured.push({ method: req.method ?? '', url: req.url ?? '', headers: req.headers, body })
        const reply = responses.get(`${req.method} ${req.url}`) ?? { status: 404, body: { detail: 'Not found.' } }
        res.writeHead(reply.status, { 'Content-Type': 'application/json' })
        res.end(JSON.stringify(reply.body))
      })
    })
    await new Promise<void>((resolve) => server.listen(0, '127.0.0.1', resolve))
    baseUrl = `http://127.0.0.1:${(server.address() as AddressInfo).port}`
  })

  afterAll(() => new Promise<void>((resolve) => server.close(() => resolve())))

  async function call(pkg: string, api: string, op: string, args: unknown[]) {
    const before = captured.length
    const result = await probe(pkg, 'call', baseUrl, api, op, JSON.stringify(args))
    expect(captured.length).toBe(before + 1)
    return { result, request: captured[captured.length - 1] }
  }

  it('personal_tokens: GET by id sends the token header and deserializes the model', async () => {
    const id = '7f3a1c2e-0000-4000-8000-000000000001'
    responses.set(`GET /iam/personal_tokens/${id}`, {
      status: 200,
      body: { uuid: id, name: 'ci', created: '2026-01-02T03:04:05Z', expires_at: '2027-01-02T03:04:05Z', description: 'pipeline' },
    })
    const { result, request } = await call('personal_tokens', 'PersonalTokenApi', 'GetPersonalToken', [id])
    expect(request.method).toBe('GET')
    expect(request.headers.authorization).toBe('Token test-token')
    expect(request.headers.accept).toContain('application/json')
    expect(result.error).toBeNull()
    expect(result.dataType).toBe('PersonalTokenResponseGet')
    expect(result.data).toMatchObject({ uuid: id, name: 'ci', description: 'pipeline' })
  })

  it('variables: list returns typed Variable objects', async () => {
    const variable = { uuid: '0b1e8a52-0000-4000-8000-0000000000a1', key: 'API_URL', value: 'https://example.test', secret: false, last_editor: 'ci', created_at: '2026-01-01T00:00:00Z', updated_at: '2026-01-01T00:00:00Z' }
    responses.set('GET /variables', { status: 200, body: [variable] })
    const { result, request } = await call('variables', 'VariablesApi', 'ApiVariablesList', [])
    expect(request.headers.authorization).toBe('Token test-token')
    expect(result.error).toBeNull()
    expect(result.data).toHaveLength(1)
    // The probe re-serializes the model; read-only properties (uuid, secret, ...) are not emitted.
    expect(result.data[0]).toMatchObject({ key: 'API_URL', value: 'https://example.test' })
  })

  it('idns: path parameters are encoded into the route and HTTP errors raise ApiException', async () => {
    responses.set('GET /intelligent_dns/42', { status: 200, body: { schema_version: 3, results: { id: 42, name: 'example zone', domain: 'example.test', is_active: true } } })
    const ok = await call('idns', 'ZonesApi', 'GetZone', [42])
    expect(ok.request.url).toBe('/intelligent_dns/42')
    expect(ok.request.headers.authorization).toBe('Token test-token')
    expect(ok.result.dataType).toBe('GetZoneResponse')
    expect(ok.result.data.results).toMatchObject({ id: 42, domain: 'example.test' })
    const missing = await call('idns', 'ZonesApi', 'GetZone', [999])
    expect(missing.request.url).toBe('/intelligent_dns/999')
    expect(missing.result.error).toEqual({ status: 404 })
  })
})
