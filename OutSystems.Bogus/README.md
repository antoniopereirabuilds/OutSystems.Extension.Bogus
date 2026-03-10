# OutSystems.Bogus

Core library for the OutSystems.Extension.Bogus project. This package wraps the .NET [Bogus](https://github.com/bchavez/Bogus) library and exposes it as OutSystems Developer Cloud (ODC) external library server actions.

## Overview

- **10 interface groups** with 63 server actions for generating fake data.
- **50+ locales** supported via the Bogus library.
- **Deterministic output** with seed parameter for reproducible test data.
- **2 data structures**: `FakePersonData` and `FakeCurrencyData`.

## Interface Groups

| Interface | Actions | Data Categories |
|-----------|---------|-----------------|
| IFakePerson | 9 | Names, emails, phones, DOB, job titles |
| IFakeAddress | 9 | Addresses, cities, countries, coordinates |
| IFakeCompany | 4 | Company names, suffixes, catch phrases |
| IFakeFinance | 7 | Credit cards, IBANs, amounts, currencies |
| IFakeInternet | 7 | URLs, IPs, passwords, colors, user agents |
| IFakeText | 6 | Lorem ipsum words, sentences, paragraphs |
| IFakeCommerce | 6 | Products, prices, categories, barcodes |
| IFakeDate | 5 | Past, future, recent, soon, between dates |
| IFakeSystem | 4 | File names, MIME types, extensions, semver |
| IFakeRandomizer | 6 | GUIDs, numbers, booleans, hashes |

## Dependencies

- [Bogus](https://github.com/bchavez/Bogus) v35.6.1
- [OutSystems.ExternalLibraries.SDK](https://www.nuget.org/packages/OutSystems.ExternalLibraries.SDK) v1.5.0
- .NET 8.0

## Build

```bash
dotnet build OutSystems.Bogus/OutSystems.Bogus.csproj --configuration Release
```

## Publish (for ODC deployment)

```bash
dotnet publish OutSystems.Bogus/OutSystems.Bogus.csproj -c Release -r linux-x64 --self-contained false -o ./publish
```

See the [root README](../README.md) for full documentation, installation instructions, and usage examples.
