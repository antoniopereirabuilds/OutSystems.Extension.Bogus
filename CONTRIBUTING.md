# Contributing to OutSystems.Extension.Bogus

Thank you for considering contributing to this project. This guide explains how to get started.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A C# IDE (Visual Studio, VS Code with C# Dev Kit, JetBrains Rider)

## Getting Started

1. Fork the repository and clone your fork:

   ```bash
   git clone https://github.com/<your-username>/OutSystems.Extension.Bogus.git
   cd OutSystems.Extension.Bogus
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

3. Build the project:

   ```bash
   dotnet build --configuration Release
   ```

4. Run tests:

   ```bash
   dotnet test OutSystems.Bogus.UnitTests/OutSystems.Bogus.UnitTests.csproj --configuration Release
   ```

## Project Structure

```
OutSystems.Bogus/               Main library
  IFake*.cs                     Interface definitions (OSInterface/OSAction attributes)
  Fake*.cs                      Implementations
  Structures.cs                 Data structures (FakePersonData, FakeCurrencyData)
  FakerHelper.cs                Shared helper (Faker factory, validation)
OutSystems.Bogus.UnitTests/     Unit tests (NUnit)
  Bogus.*.Tests.cs              One test class per interface group
```

## Adding a New Action

1. **Define the interface method** in the appropriate `IFake*.cs` file with:
   - XML doc comments (`<summary>`, `<param>`, `<returns>`, `<example>`, `<remarks>`)
   - `[OSAction]` attribute with Description and ReturnName
   - `[OSParameterAttribute]` on each parameter

2. **Implement the method** in the corresponding `Fake*.cs` class using `FakerHelper.CreateFaker()`.

3. **Add unit tests** in the corresponding `Bogus.*.Tests.cs` file covering:
   - Non-empty/null output
   - Seed determinism
   - Locale support (if applicable)
   - Range/format validation (if applicable)

4. **Update the README** action table for the relevant interface group.

## Adding a New Interface Group

1. Create `IFakeNewGroup.cs` with the `[OSInterface]` attribute.
2. Create `FakeNewGroup.cs` implementing the interface.
3. Create `Bogus.NewGroup.Tests.cs` with comprehensive tests.
4. Add the new group to the README action tables.

## Code Style

- Follow existing patterns — each action uses `FakerHelper.CreateFaker()` or `FakerHelper.CreateRandomizer()`.
- Use `FakerHelper.ValidateCount()` and `FakerHelper.ValidateLength()` for user-provided counts/lengths.
- Keep XML doc comments consistent with existing methods.
- All public interface methods must have `[OSAction]` and `[OSParameterAttribute]` decorators.

## Pull Request Process

1. Create a feature branch from `main`.
2. Make your changes and ensure all tests pass.
3. Update documentation (README, CHANGELOG) as needed.
4. Submit a pull request with a clear description of the changes.

## Reporting Issues

Open an issue on GitHub with:
- A clear description of the problem or feature request.
- Steps to reproduce (for bugs).
- Expected vs actual behavior.

## License

By contributing, you agree that your contributions will be licensed under the [BSD-2-Clause License](LICENSE).
