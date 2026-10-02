# azionapi-csharp-sdk

.NET client packages for the Azion APIs, generated with
[OpenAPI Generator](https://openapi-generator.tech) (`csharp` generator). Each top-level
directory is an independent solution (`src/<package>/<package>.csproj` plus a test
project) with its own `README.md` and `docs/`. Most packages use the RestSharp library;
`edgeapplications` and `edgefunctions` were generated with the `generichost` library
(HttpClient and dependency injection).

## Packages

| Directory | Target framework | HTTP library | API classes |
|-----------|------------------|--------------|-------------|
| `credentials` | `netstandard2.0` | RestSharp | `DefaultApi` |
| `data_streaming` | `net7.0` | RestSharp | `DataStreamingApi`, `DataStreamingDomainApi`, `DataStreamingTemplatesApi` |
| `digital_certificates` | `netstandard2.0` | RestSharp | `CreateCSRApi`, `CreateDigitalCertificateApi`, `DeleteDigitalCertificateApi`, `OverwriteDigitalCertificateApi`, `RetrieveDigitalCertificateByIDApi`, `RetrieveDigitalCertificateListApi`, `UpdateDigitalCertificateApi` |
| `domains` | `net8.0` | RestSharp | `DomainsApi` |
| `edgeapplications` | `net9.0` | HttpClient (generichost) | `EdgeApplicationsCacheSettingsApi`, `EdgeApplicationsDeviceGroupsApi`, `EdgeApplicationsEdgeFunctionsInstancesApi`, `EdgeApplicationsMainSettingsApi`, `EdgeApplicationsOriginsApi`, `EdgeApplicationsRulesEngineApi` |
| `edgefirewall` | `net7.0` | RestSharp | `DefaultApi` |
| `edgefunctions` | `net9.0` | HttpClient (generichost) | `EdgeFunctionsApi` |
| `edgefunctionsinstance_edgefirewall` | `net7.0` | RestSharp | `DefaultApi` |
| `edgenode` | `netstandard2.0` | RestSharp | `DefaultApi` |
| `idns` | `net7.0` | RestSharp | `DNSSECApi`, `RecordsApi`, `ZonesApi` |
| `networklist` | `net7.0` | RestSharp | `DefaultApi` |
| `personal_tokens` | `netstandard2.0` | RestSharp | `PersonalTokenApi` |
| `realtimepurge` | `netstandard2.0` | RestSharp | `RealTimePurgeApi` |
| `services` | `netstandard2.0` | RestSharp | `DefaultApi` |
| `storage` | `net8.0` | RestSharp | `BucketsApi`, `StorageApi` |
| `storageapi` | `netstandard2.0` | RestSharp | `DefaultApi` |
| `variables` | `net7.0` | RestSharp | `ApiApi`, `VariablesApi` |
| `waf` | `net7.0` | RestSharp | `WAFApi` |

## Requirements

- .NET SDK able to build the package's target framework (CI uses .NET SDK 9)

## Installation

Reference the project of the package you need from your solution:

```bash
dotnet add MyApp.csproj reference path/to/azionapi-csharp-sdk/personal_tokens/src/personal_tokens/personal_tokens.csproj
```

## Usage (RestSharp packages)

Authenticate with an Azion personal token in the `Authorization` header using the
`Token` prefix:

```csharp
using personal_tokens.Api;
using personal_tokens.Client;

var config = new Configuration();
config.ApiKey.Add("Authorization", Environment.GetEnvironmentVariable("AZION_TOKEN"));
config.ApiKeyPrefix.Add("Authorization", "Token");

var api = new PersonalTokenApi(config);
var tokens = api.ListPersonalToken();
```

For the `generichost` packages, see the package README (`src/<package>/README.md`) for the
dependency-injection setup. Each package README lists every endpoint and model.

## Tests

Functional tests live in `tests/vitest/` and run in CI (`.github/workflows/ci-tests.yml`):

```bash
cd tests/vitest
npm ci
npm test   # needs the .NET 9 SDK on PATH
```

They build every package from its own project file, check through a reflection probe
(`tests/vitest/harness/Probe`) that every endpoint documented in a RestSharp package
README is sent with the right HTTP verb and route, check that the `generichost` packages
declare every documented endpoint, and run real HTTP calls against a local API double
(authentication header, path parameters, model deserialization and `ApiException` on
HTTP errors).

## Versioning

Every push to `main` is tagged with the next SemVer version (`vX.Y.Z`) by
`.github/workflows/bump_version.yml`. Notable changes are recorded in `CHANGELOG.md`.

## Contributing and security

See [CONTRIBUTING.md](CONTRIBUTING.md). Report vulnerabilities privately as described in
[SECURITY.md](SECURITY.md).

## License

[MIT](LICENSE)
