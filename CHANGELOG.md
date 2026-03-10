# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- Initial release of OutSystems.Extension.Bogus.
- 10 interface groups with 63 server actions covering: Person, Address, Company, Finance, Internet, Text, Commerce, Date, System, and Randomizer.
- 2 data structures: `FakePersonData` (9 fields) and `FakeCurrencyData` (3 fields).
- Locale support for 50+ locales via the Bogus library.
- Deterministic output via seed parameter (seed > 0 = reproducible, seed = 0 = random).
- `GenerateFakePerson` batch action for generating a complete person in one call.
- Input validation with safe limits (count max 10,000; length max 100,000).
- Unit test suite with 10 test classes covering all actions.
- GitHub Actions CI pipeline with automated testing and code coverage reporting.
- GitHub Actions release pipeline with automated packaging and GitHub Releases.
