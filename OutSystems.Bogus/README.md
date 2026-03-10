# OutSystems.Bogus

Core library for the OutSystems.Extension.Bogus project. This package wraps the .NET [Bogus](https://github.com/bchavez/Bogus) library and exposes it as OutSystems Developer Cloud (ODC) external library server actions.

## Overview

- **1 unified interface** (`IFakeBogus` / `FakeBogus`) with 63 server actions organized into 10 regions.
- **OSInterface Name:** "Bogus" (ODC allows only 1 OSInterface per DLL).
- **50+ locales** supported via the Bogus library.
- **Deterministic output** with seed parameter for reproducible test data.
- **2 data structures**: `FakePersonData` and `FakeCurrencyData`.

## Action Regions

All actions belong to the single `IFakeBogus` interface, organized by `#region` blocks:

| Region | Actions | Data Categories |
|--------|---------|-----------------|
| Person | 9 | Names, emails, phones, DOB, job titles |
| Address | 9 | Addresses, cities, countries, coordinates |
| Company | 4 | Company names, suffixes, catch phrases |
| Finance | 7 | Credit cards, IBANs, amounts, currencies |
| Internet | 7 | URLs, IPs, passwords, colors, user agents |
| Text | 6 | Lorem ipsum words, sentences, paragraphs |
| Commerce | 6 | Products, prices, categories, barcodes |
| Date | 5 | Past, future, recent, soon, between dates |
| System | 4 | File names, MIME types, extensions, semver |
| Randomizer | 6 | GUIDs, numbers, booleans, hashes |

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
