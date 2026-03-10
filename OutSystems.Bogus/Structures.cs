using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Represents a generated fake person with identity details.
    /// </summary>
    [OSStructure(Description = "Represents a generated fake person with identity details.")]
    public struct FakePersonData
    {
        [OSStructureField(Description = "First name.", IsMandatory = false)]
        public string FirstName;

        [OSStructureField(Description = "Last name.", IsMandatory = false)]
        public string LastName;

        [OSStructureField(Description = "Full name (first + last).", IsMandatory = false)]
        public string FullName;

        [OSStructureField(Description = "Email address.", IsMandatory = false)]
        public string Email;

        [OSStructureField(Description = "Phone number.", IsMandatory = false)]
        public string Phone;

        [OSStructureField(Description = "Date of birth.", IsMandatory = false, DataType = OSDataType.DateTime)]
        public DateTime DateOfBirth;

        [OSStructureField(Description = "Username.", IsMandatory = false)]
        public string UserName;

        [OSStructureField(Description = "Job title.", IsMandatory = false)]
        public string JobTitle;

        [OSStructureField(Description = "Gender (Male or Female).", IsMandatory = false)]
        public string Gender;

        public FakePersonData()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            FullName = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            DateOfBirth = DateTime.MinValue;
            UserName = string.Empty;
            JobTitle = string.Empty;
            Gender = string.Empty;
        }
    }

    /// <summary>
    /// Represents a currency with name, code, and symbol.
    /// </summary>
    [OSStructure(Description = "Represents a currency with name, code, and symbol.")]
    public struct FakeCurrencyData
    {
        [OSStructureField(Description = "Currency name (e.g., US Dollar).", IsMandatory = false)]
        public string Name;

        [OSStructureField(Description = "ISO 4217 currency code (e.g., USD).", IsMandatory = false)]
        public string Code;

        [OSStructureField(Description = "Currency symbol (e.g., $).", IsMandatory = false)]
        public string Symbol;

        public FakeCurrencyData()
        {
            Name = string.Empty;
            Code = string.Empty;
            Symbol = string.Empty;
        }
    }
}
