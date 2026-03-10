using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake person and identity data using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake person and identity data (names, emails, phones, etc.) using the Bogus library.",
        Name = "FakePerson",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakePerson
    {
        /// <summary>
        /// Generates a fake first name.
        /// </summary>
        /// <remarks>
        /// The generated name respects the specified locale. For example, locale "ja" produces Japanese names.
        /// </remarks>
        /// <example>
        /// <code>
        /// string name = fakePerson.FakeFirstName("en", 42); // deterministic
        /// string randomName = fakePerson.FakeFirstName(); // random English name
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake first name.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "FirstName"
        )]
        string FakeFirstName(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake last name.
        /// </summary>
        /// <remarks>
        /// The generated surname respects the specified locale.
        /// </remarks>
        /// <example>
        /// <code>
        /// string surname = fakePerson.FakeLastName("pt_BR", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake last name.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "LastName"
        )]
        string FakeLastName(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake full name.
        /// </summary>
        /// <remarks>
        /// Returns a combined first and last name. The name parts are generated together to ensure natural pairing.
        /// </remarks>
        /// <example>
        /// <code>
        /// string fullName = fakePerson.FakeFullName("de", 42); // German full name
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake full name (first + last).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "FullName"
        )]
        string FakeFullName(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake email address.
        /// </summary>
        /// <remarks>
        /// The email is generated with a plausible format (e.g., firstname.lastname@example.com). The domain is fictional.
        /// </remarks>
        /// <example>
        /// <code>
        /// string email = fakePerson.FakeEmail("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake email address.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Email"
        )]
        string FakeEmail(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake username.
        /// </summary>
        /// <remarks>
        /// Usernames are generated from name-like components and may include dots, underscores, or numbers.
        /// </remarks>
        /// <example>
        /// <code>
        /// string user = fakePerson.FakeUserName("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake username.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "UserName"
        )]
        string FakeUserName(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake phone number.
        /// </summary>
        /// <remarks>
        /// The phone format varies by locale. For example, "en" produces US-style numbers while "pt_BR" produces Brazilian formats.
        /// </remarks>
        /// <example>
        /// <code>
        /// string phone = fakePerson.FakePhoneNumber("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake phone number.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "PhoneNumber"
        )]
        string FakePhoneNumber(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake date of birth within the specified age range.
        /// </summary>
        /// <remarks>
        /// The date is calculated backward from today. A minAge of 18 and maxAge of 65 generates a birth date for someone currently between 18 and 65 years old.
        /// </remarks>
        /// <example>
        /// <code>
        /// DateTime dob = fakePerson.FakeDateOfBirth(minAge: 21, maxAge: 30, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake date of birth within the specified age range.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "DateOfBirth"
        )]
        DateTime FakeDateOfBirth(
            [OSParameterAttribute(Description = "Minimum age. Default is 18.")]
            int minAge = 18,
            [OSParameterAttribute(Description = "Maximum age. Default is 65.")]
            int maxAge = 65,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake job title.
        /// </summary>
        /// <remarks>
        /// Job titles are composed of descriptor, level, and job components (e.g., "Senior Data Engineer").
        /// </remarks>
        /// <example>
        /// <code>
        /// string job = fakePerson.FakeJobTitle("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake job title.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "JobTitle"
        )]
        string FakeJobTitle(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a complete fake person with all identity fields populated.
        /// </summary>
        /// <remarks>
        /// Returns a <see cref="FakePersonData"/> structure with FirstName, LastName, FullName, Email, Phone, DateOfBirth, UserName, JobTitle, and Gender populated in a single call. This is more efficient than calling individual actions separately when you need multiple fields for the same person.
        /// </remarks>
        /// <example>
        /// <code>
        /// FakePersonData person = fakePerson.GenerateFakePerson("pt_BR", 100);
        /// // person.FirstName, person.Email, person.Phone, etc.
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a complete fake person with all identity fields populated.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Person"
        )]
        FakePersonData GenerateFakePerson(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );
    }
}
