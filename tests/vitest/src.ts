import { readFileSync, readdirSync, statSync } from 'node:fs'
import path from 'node:path'

export const ROOT = path.resolve(__dirname, '../..')
export const HARNESS = path.resolve(__dirname, 'harness')
export const BUILD = path.resolve(__dirname, '.build')

function isFile(file: string): boolean {
  try {
    return statSync(file).isFile()
  } catch {
    return false
  }
}

// Every top-level directory with src/<name>/<name>.csproj is a generated package.
export const PACKAGES = readdirSync(ROOT).filter((d) => isFile(project(d)))

export function project(pkg: string): string {
  return path.join(ROOT, pkg, 'src', pkg, `${pkg}.csproj`)
}

// Packages generated with the "generichost" library (HttpClient + DI) instead of RestSharp.
export function isGenericHost(pkg: string): boolean {
  return readFileSync(project(pkg), 'utf8').includes('Microsoft.Extensions.Hosting')
}

export function output(pkg: string): string {
  return path.join(BUILD, pkg, `${pkg}.dll`)
}
