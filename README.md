# OutSystems.Extension.Bogus

[![CI - Run Tests](../../actions/workflows/test.yml/badge.svg)](../../actions/workflows/test.yml)
[![License: BSD-2-Clause](https://img.shields.io/badge/License-BSD_2--Clause-blue.svg)](LICENSE)
[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![Bogus v35.6.1](https://img.shields.io/badge/Bogus-v35.6.1-green.svg)](https://github.com/bchavez/Bogus)
[![OutSystems ODC](https://img.shields.io/badge/OutSystems-ODC-red.svg)](https://www.outsystems.com/developer-cloud/)

Generate realistic fake data directly inside OutSystems Developer Cloud (ODC) — names, addresses, emails, credit cards, dates, and 60+ other data types. This external library wraps the battle-tested .NET [Bogus](https://github.com/bchavez/Bogus) library and exposes it as ODC server actions with full locale and seed support for deterministic, reproducible test data.

## Use Cases

- **Populate demo environments** with realistic-looking data for stakeholder presentations.
- **Seed automated tests** with deterministic data using the seed parameter — same seed, same output, every time.
- **Generate locale-specific data** for multilingual applications (50+ locales supported).
- **Prototype quickly** without waiting for real data or creating manual test records.
- **Load test applications** by generating high volumes of diverse, realistic records.

## Installation

### 1. Download the release

Go to the [Releases](../../releases) page and download the latest `Bogus_vX.X.X.zip` file.

### 2. Upload to ODC Portal

1. Open the **ODC Portal** and navigate to **Forge** > **External Libraries**.
2. Click **Upload new library** and select the downloaded ZIP file.
3. Wait for the upload and validation to complete.

### 3. Use in ODC Studio

1. In ODC Studio, open your application.
2. Go to the **Logic** tab and click **Add public elements** (Ctrl+Q).
3. Search for **Bogus** or any action name (e.g., `FakeEmail`, `FakeFullName`).
4. Select the actions you need and click **Add**.
5. Drag the actions into your server action flows.

## Quick Start Examples

### Generate a fake person (OutSystems server action flow)

```
-- In a Server Action flow:
1. Drag "GenerateFakePerson" into the flow
2. Set locale = "en" (or "pt_BR", "fr", "de", etc.)
3. Set seed = 0 for random, or seed = 42 for deterministic output
4. The output "Person" contains: FirstName, LastName, FullName,
   Email, Phone, DateOfBirth, UserName, JobTitle, Gender
```

### Generate deterministic test data

```
-- Using seed for reproducible tests:
FakeEmail(locale: "en", seed: 12345)  →  always returns the same email
FakeEmail(locale: "en", seed: 0)      →  returns a different email each time
```

### Generate locale-specific data

```
FakeFullName(locale: "pt_BR")  →  Brazilian Portuguese name
FakeFullName(locale: "ja")     →  Japanese name
FakeFullName(locale: "de")     →  German name
FakeCity(locale: "fr")         →  French city name
```

### C# usage (for developers extending the library)

```csharp
// Generate a fake person
var fakePerson = new FakePerson();
string name = fakePerson.FakeFullName(locale: "en", seed: 42);
string email = fakePerson.FakeEmail(locale: "en", seed: 42);

// Generate a complete person record in one call
FakePersonData person = fakePerson.GenerateFakePerson(locale: "pt_BR", seed: 100);
// person.FirstName, person.LastName, person.Email, etc.

// Generate financial data
var fakeFinance = new FakeFinance();
string iban = fakeFinance.FakeIban(locale: "en", seed: 42);
decimal amount = fakeFinance.FakeAmount(min: 10, max: 500, decimals: 2);
```

## Structures

### FakePersonData

Represents a generated fake person with identity details.

| Field | Type | Description |
|-------|------|-------------|
| FirstName | Text | First name. |
| LastName | Text | Last name. |
| FullName | Text | Full name (first + last). |
| Email | Text | Email address. |
| Phone | Text | Phone number. |
| DateOfBirth | Date Time | Date of birth. |
| UserName | Text | Username. |
| JobTitle | Text | Job title. |
| Gender | Text | Gender (Male or Female). |

### FakeCurrencyData

Represents a currency with name, code, and symbol.

| Field | Type | Description |
|-------|------|-------------|
| Name | Text | Currency name (e.g., US Dollar). |
| Code | Text | ISO 4217 currency code (e.g., USD). |
| Symbol | Text | Currency symbol (e.g., $). |

## Actions

### FakePerson (IFakePerson)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeFirstName | Generates a fake first name. | locale, seed | Text |
| FakeLastName | Generates a fake last name. | locale, seed | Text |
| FakeFullName | Generates a fake full name. | locale, seed | Text |
| FakeEmail | Generates a fake email address. | locale, seed | Text |
| FakeUserName | Generates a fake username. | locale, seed | Text |
| FakePhoneNumber | Generates a fake phone number. | locale, seed | Text |
| FakeDateOfBirth | Generates a fake date of birth. | minAge, maxAge, seed | Date Time |
| FakeJobTitle | Generates a fake job title. | locale, seed | Text |
| GenerateFakePerson | Generates a complete fake person. | locale, seed | FakePersonData |

### FakeAddress (IFakeAddress)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeFullAddress | Generates a fake full address. | locale, seed | Text |
| FakeCity | Generates a fake city name. | locale, seed | Text |
| FakeCountry | Generates a fake country name. | locale, seed | Text |
| FakeCountryCode | Generates a fake country code. | locale, seed | Text |
| FakeZipCode | Generates a fake zip/postal code. | locale, seed | Text |
| FakeState | Generates a fake state/province. | locale, seed | Text |
| FakeStreetAddress | Generates a fake street address. | locale, seed | Text |
| FakeLatitude | Generates a fake latitude. | seed | Decimal |
| FakeLongitude | Generates a fake longitude. | seed | Decimal |

### FakeCompany (IFakeCompany)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeCompanyName | Generates a fake company name. | locale, seed | Text |
| FakeCompanySuffix | Generates a company suffix. | locale, seed | Text |
| FakeCatchPhrase | Generates a catch phrase. | locale, seed | Text |
| FakeBs | Generates a BS phrase. | locale, seed | Text |

### FakeFinance (IFakeFinance)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeCreditCardNumber | Generates a credit card number. | seed | Text |
| FakeCreditCardCvv | Generates a CVV. | seed | Text |
| FakeIban | Generates an IBAN. | seed | Text |
| FakeBic | Generates a BIC/SWIFT code. | seed | Text |
| FakeAmount | Generates a monetary amount. | min, max, decimals, seed | Decimal |
| FakeCurrency | Generates a currency. | seed | FakeCurrencyData |
| FakeAccountNumber | Generates a bank account number. | seed | Text |

### FakeInternet (IFakeInternet)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeUrl | Generates a URL. | seed | Text |
| FakeIp | Generates an IPv4 address. | seed | Text |
| FakeIpv6 | Generates an IPv6 address. | seed | Text |
| FakeMacAddress | Generates a MAC address. | seed | Text |
| FakePassword | Generates a password. | length, seed | Text |
| FakeColor | Generates a hex color. | seed | Text |
| FakeUserAgent | Generates a user agent string. | seed | Text |

### FakeText (IFakeText)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeLoremWord | Generates a single word. | seed | Text |
| FakeLoremWords | Generates multiple words. | count, seed | Text |
| FakeLoremSentence | Generates a sentence. | wordCount, seed | Text |
| FakeLoremParagraph | Generates a paragraph. | seed | Text |
| FakeLoremParagraphs | Generates multiple paragraphs. | count, seed | Text |
| FakeLoremSlug | Generates a URL slug. | wordCount, seed | Text |

### FakeCommerce (IFakeCommerce)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeProductName | Generates a product name. | seed | Text |
| FakeProductPrice | Generates a product price. | min, max, seed | Text |
| FakeDepartment | Generates a department name. | seed | Text |
| FakeProductCategory | Generates a product category. | seed | Text |
| FakeEan13 | Generates an EAN-13 barcode. | seed | Text |
| FakeEan8 | Generates an EAN-8 barcode. | seed | Text |

### FakeDate (IFakeDate)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakePastDate | Generates a past date. | yearsToGoBack, seed | Date Time |
| FakeFutureDate | Generates a future date. | yearsToGoForward, seed | Date Time |
| FakeDateBetween | Generates a date between two dates. | start, end, seed | Date Time |
| FakeRecentDate | Generates a recent date. | days, seed | Date Time |
| FakeSoonDate | Generates a soon date. | days, seed | Date Time |

### FakeSystem (IFakeSystem)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeFileName | Generates a file name. | seed | Text |
| FakeMimeType | Generates a MIME type. | seed | Text |
| FakeFileExtension | Generates a file extension. | seed | Text |
| FakeSemver | Generates a semantic version. | seed | Text |

### FakeRandomizer (IFakeRandomizer)

| Action | Description | Key Parameters | Return |
|--------|-------------|----------------|--------|
| FakeGuid | Generates a GUID string. | seed | Text |
| FakeNumber | Generates an integer. | min, max, seed | Integer |
| FakeDecimal | Generates a decimal. | min, max, seed | Decimal |
| FakeBoolean | Generates a boolean. | weight, seed | Boolean |
| FakeHash | Generates a hex hash. | length, seed | Text |
| FakeAlphaNumeric | Generates an alphanumeric string. | length, seed | Text |

## Frequently Asked Questions

### What locales are supported?

All locales supported by the [Bogus library](https://github.com/bchavez/Bogus#locales) are available, including: `af_ZA`, `ar`, `az`, `cz`, `de`, `de_AT`, `de_CH`, `el`, `en`, `en_AU`, `en_AU_ocker`, `en_BORK`, `en_CA`, `en_GB`, `en_IE`, `en_IND`, `en_NG`, `en_US`, `en_ZA`, `es`, `es_MX`, `fa`, `fi`, `fr`, `fr_CA`, `fr_CH`, `ge`, `hr`, `id_ID`, `it`, `ja`, `ko`, `lv`, `nb_NO`, `ne`, `nl`, `nl_BE`, `pl`, `pt_BR`, `pt_PT`, `ro`, `ru`, `sk`, `sv`, `tr`, `uk`, `vi`, `zh_CN`, `zh_TW`, `zu_ZA`. The default locale is `"en"`.

### How do I get deterministic/reproducible test data?

Set the `seed` parameter to any integer greater than 0. The same seed always produces the same output. For example, `FakeEmail(locale: "en", seed: 42)` will return the identical email every time. Set `seed = 0` (the default) for random output.

### Can I generate a complete person in one call?

Yes. Use the `GenerateFakePerson` action, which returns a `FakePersonData` structure containing FirstName, LastName, FullName, Email, Phone, DateOfBirth, UserName, JobTitle, and Gender — all populated in a single call. This is more efficient than calling individual actions separately.

### What is the difference between FakeRecentDate and FakePastDate?

`FakeRecentDate` generates a date within the last N **days** (default: 1 day), while `FakePastDate` generates a date within the last N **years** (default: 1 year). Use `FakeRecentDate` for timestamps in the last few days; use `FakePastDate` for dates further in the past.

### What is the difference between FakeSoonDate and FakeFutureDate?

`FakeSoonDate` generates a date within the next N **days** (default: 1 day), while `FakeFutureDate` generates a date within the next N **years** (default: 1 year). Same pattern as Recent vs Past, but looking forward.

### Are there limits on generated data?

Yes. Count parameters (e.g., number of words or paragraphs) are capped at 10,000. Length parameters (e.g., password or hash length) are capped at 100,000. Values outside these ranges throw an `ArgumentOutOfRangeException`.

### What characters does FakePassword use?

`FakePassword` generates passwords containing a mix of lowercase letters, uppercase letters, digits, and special characters. The `length` parameter controls the total character count (default: 10).

### Is the generated data safe for production use?

This library is designed for **test and demo data only**. Generated credit card numbers, IBANs, and other financial data are syntactically plausible but not real. Never use generated data as actual credentials or financial instruments.

## Technical Details

- **Library:** Bogus v35.6.1
- **Target:** .NET 8.0, linux-x64 (framework-dependent)
- **ODC SDK:** OutSystems.ExternalLibraries.SDK v1.5.0
- **License:** [BSD-2-Clause](LICENSE)
- **CI/CD:** GitHub Actions (automated tests + coverage on push/PR, release packaging on tags)

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines on how to contribute to this project.

## License

This project is licensed under the BSD-2-Clause License. See the [LICENSE](LICENSE) file for details.
