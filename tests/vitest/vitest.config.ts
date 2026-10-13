import { defineConfig } from 'vitest/config'

export default defineConfig({
  test: {
    // Building 18 .NET projects takes a while on a cold NuGet cache.
    globalSetup: ['./globalSetup.ts'],
    hookTimeout: 1_800_000,
    testTimeout: 120_000,
    include: ['functional/**/*.test.ts'],
  },
})
