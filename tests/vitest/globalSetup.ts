import { execFile } from 'node:child_process'
import { mkdirSync, writeFileSync } from 'node:fs'
import path from 'node:path'
import { promisify } from 'node:util'
import { BUILD, HARNESS, PACKAGES, project } from './src'

const run = promisify(execFile)
const DOTNET = process.env.DOTNET_BIN ?? 'dotnet'
const PARALLEL = Number(process.env.BUILD_PARALLELISM ?? 4)

const args = (csproj: string, out: string) => [
  'build', csproj, '-c', 'Release', '-nologo', '-v', 'q',
  '-p:CopyLocalLockFileAssemblies=true', '-p:GenerateDocumentationFile=false', '-o', out,
]

// Build the probe, then every package from its own .csproj (dependencies copied next to
// the assembly so the probe can load it). Package build results are recorded in
// .build/results.json and asserted by the tests.
export default async function setup() {
  mkdirSync(BUILD, { recursive: true })
  // The probe goes first: the first dotnet invocation initialises NuGet state, which is
  // not safe to do from several processes at once.
  await run(DOTNET, args(path.join(HARNESS, 'Probe', 'Probe.csproj'), path.join(BUILD, 'probe')), { maxBuffer: 64 * 1024 * 1024 })
  const results: Record<string, { ok: boolean; log: string }> = {}
  const queue = [...PACKAGES]
  const worker = async () => {
    for (let pkg = queue.shift(); pkg; pkg = queue.shift()) {
      try {
        await run(DOTNET, args(project(pkg), path.join(BUILD, pkg)), { maxBuffer: 64 * 1024 * 1024 })
        results[pkg] = { ok: true, log: '' }
      } catch (err) {
        const e = err as { stdout?: string; stderr?: string }
        results[pkg] = { ok: false, log: `${e.stdout ?? ''}\n${e.stderr ?? ''}` }
      }
    }
  }
  await Promise.all(Array.from({ length: PARALLEL }, worker))
  writeFileSync(path.join(BUILD, 'results.json'), JSON.stringify(results, null, 2))
}
