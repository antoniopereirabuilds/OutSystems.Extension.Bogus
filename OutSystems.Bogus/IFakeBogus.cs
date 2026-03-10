using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake data for testing and development using the Bogus library.
    /// Provides 63 actions across 10 categories: Person, Address, Company, Finance,
    /// Internet, Text, Commerce, Date, System, and Randomizer.
    /// </summary>
    [OSInterface(
        Description = "Generates fake data for testing and development (persons, addresses, finance, internet, text, commerce, dates, system, randomizer) using the Bogus library.",
        Name = "Bogus",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeBogus
    {
        #region Person

        /// <summary>
        /// Returns a random first name.
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
            Description = "Returns a random first name.",
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
        /// Returns a random last name.
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
            Description = "Returns a random last name.",
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
        /// Returns a random full name (first + last).
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
            Description = "Returns a random full name (first + last).",
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
        /// Generates a fictional username.
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
            Description = "Generates a fictional username.",
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
        /// Generates a random date of birth within the specified age range.
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
            Description = "Generates a random date of birth within the specified age range.",
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
        /// Generates a realistic job title.
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
            Description = "Generates a realistic job title.",
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
        /// Generates a complete fictional person with all identity fields populated.
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
            Description = "Generates a complete fictional person with all identity fields populated.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Person"
        )]
        FakePersonData GenerateFakePerson(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Address

        /// <summary>
        /// Generates a realistic full address.
        /// </summary>
        /// <remarks>
        /// Returns a complete address string including street number, street name, city, state, and zip code.
        /// </remarks>
        /// <example>
        /// <code>
        /// string address = fakeAddress.FakeFullAddress("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a realistic full address.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "FullAddress"
        )]
        string FakeFullAddress(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random city name.
        /// </summary>
        /// <remarks>
        /// City names are locale-sensitive. For example, "fr" produces French city names.
        /// </remarks>
        /// <example>
        /// <code>
        /// string city = fakeAddress.FakeCity("fr", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Returns a random city name.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "City"
        )]
        string FakeCity(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random country name.
        /// </summary>
        /// <remarks>
        /// Returns a full country name (e.g., "United States", "Brazil").
        /// </remarks>
        [OSAction(
            Description = "Returns a random country name.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Country"
        )]
        string FakeCountry(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random country code (ISO 3166-1 alpha-2).
        /// </summary>
        /// <remarks>
        /// Returns an ISO 3166-1 alpha-2 code (e.g., "US", "BR", "DE").
        /// </remarks>
        [OSAction(
            Description = "Returns a random country code (ISO 3166-1 alpha-2).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "CountryCode"
        )]
        string FakeCountryCode(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake zip/postal code.
        /// </summary>
        /// <remarks>
        /// The zip/postal code format varies by locale (e.g., "12345" for US, "12345-678" for Brazil).
        /// </remarks>
        [OSAction(
            Description = "Generates a fake zip/postal code.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "ZipCode"
        )]
        string FakeZipCode(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random state/province name.
        /// </summary>
        /// <remarks>
        /// Returns a state, province, or region name depending on the locale.
        /// </remarks>
        [OSAction(
            Description = "Returns a random state/province name.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "State"
        )]
        string FakeState(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a realistic street address.
        /// </summary>
        /// <remarks>
        /// Returns a street address with number and street name (e.g., "123 Main Street").
        /// </remarks>
        [OSAction(
            Description = "Generates a realistic street address.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "StreetAddress"
        )]
        string FakeStreetAddress(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random latitude value.
        /// </summary>
        /// <remarks>
        /// Returns a decimal value between -90.0 and 90.0.
        /// </remarks>
        /// <example>
        /// <code>
        /// decimal lat = fakeAddress.FakeLatitude(seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random latitude value between -90 and 90.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Latitude"
        )]
        decimal FakeLatitude(
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random longitude value.
        /// </summary>
        /// <remarks>
        /// Returns a decimal value between -180.0 and 180.0.
        /// </remarks>
        /// <example>
        /// <code>
        /// decimal lon = fakeAddress.FakeLongitude(seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random longitude value between -180 and 180.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Longitude"
        )]
        decimal FakeLongitude(
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Company

        /// <summary>
        /// Generates a realistic company name.
        /// </summary>
        /// <remarks>
        /// Generates a realistic company name using locale-appropriate patterns.
        /// </remarks>
        /// <example>
        /// <code>
        /// string company = fakeCompany.FakeCompanyName("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a realistic company name.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "CompanyName"
        )]
        string FakeCompanyName(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random company suffix (e.g., LLC, Inc).
        /// </summary>
        /// <remarks>
        /// Returns a business suffix such as "LLC", "Inc", "Group", or "Ltd" depending on locale.
        /// </remarks>
        [OSAction(
            Description = "Returns a random company suffix (e.g., LLC, Inc).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "CompanySuffix"
        )]
        string FakeCompanySuffix(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a realistic company catch phrase.
        /// </summary>
        /// <remarks>
        /// Generates a corporate-style catch phrase composed of adjective, descriptor, and noun components.
        /// </remarks>
        [OSAction(
            Description = "Generates a realistic company catch phrase.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "CatchPhrase"
        )]
        string FakeCatchPhrase(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a realistic company BS phrase.
        /// </summary>
        /// <remarks>
        /// Generates a corporate buzzword phrase (e.g., "synergize scalable platforms").
        /// </remarks>
        [OSAction(
            Description = "Generates a realistic company BS phrase.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Bs"
        )]
        string FakeBs(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Finance

        /// <summary>
        /// Generates a fake credit card number.
        /// </summary>
        /// <remarks>
        /// Generates a syntactically valid credit card number using the Luhn algorithm. The number is not real and cannot be used for transactions.
        /// </remarks>
        /// <example>
        /// <code>
        /// string ccNumber = fakeFinance.FakeCreditCardNumber("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake credit card number.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "CreditCardNumber"
        )]
        string FakeCreditCardNumber(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake credit card CVV.
        /// </summary>
        /// <remarks>
        /// Generates a 3-digit CVV string. The value is randomly generated and not tied to any real card.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake credit card CVV.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Cvv"
        )]
        string FakeCreditCardCvv(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake IBAN.
        /// </summary>
        /// <remarks>
        /// Generates an International Bank Account Number in a plausible format. The IBAN is not real.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake IBAN (International Bank Account Number).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Iban"
        )]
        string FakeIban(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake BIC/SWIFT code.
        /// </summary>
        /// <remarks>
        /// Generates a Bank Identifier Code (BIC/SWIFT) in a plausible format. The code is not real.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake BIC/SWIFT code.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Bic"
        )]
        string FakeBic(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random monetary amount within the specified range.
        /// </summary>
        /// <remarks>
        /// Returns a decimal value between min and max with the specified number of decimal places. Defaults to a range of 0-1000 with 2 decimal places.
        /// </remarks>
        /// <example>
        /// <code>
        /// decimal price = fakeFinance.FakeAmount(min: 10, max: 500, decimals: 2, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random monetary amount within the specified range.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Amount"
        )]
        decimal FakeAmount(
            [OSParameterAttribute(Description = "Minimum amount. Default is 0.")]
            decimal min = 0,
            [OSParameterAttribute(Description = "Maximum amount. Default is 1000.")]
            decimal max = 1000,
            [OSParameterAttribute(Description = "Number of decimal places. Default is 2.")]
            int decimals = 2,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random real currency with name, code, and symbol.
        /// </summary>
        /// <remarks>
        /// Returns a <see cref="FakeCurrencyData"/> structure containing the currency name (e.g., "US Dollar"), ISO 4217 code (e.g., "USD"), and symbol (e.g., "$").
        /// </remarks>
        /// <example>
        /// <code>
        /// FakeCurrencyData currency = fakeFinance.FakeCurrency("en", 42);
        /// // currency.Name, currency.Code, currency.Symbol
        /// </code>
        /// </example>
        [OSAction(
            Description = "Returns a random real currency with name, code, and symbol.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Currency"
        )]
        FakeCurrencyData FakeCurrency(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake bank account number.
        /// </summary>
        /// <remarks>
        /// Generates an 8-digit bank account number string. The number is not real.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake bank account number (8 digits).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "AccountNumber"
        )]
        string FakeAccountNumber(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Internet

        /// <summary>
        /// Generates a fake URL.
        /// </summary>
        /// <remarks>
        /// Generates a URL with a plausible protocol, domain, and path.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake URL.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Url"
        )]
        string FakeUrl(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random IPv4 address.
        /// </summary>
        /// <remarks>
        /// Returns a dotted-quad IPv4 address string (e.g., "192.168.1.100").
        /// </remarks>
        [OSAction(
            Description = "Generates a random IPv4 address.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Ip"
        )]
        string FakeIp(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random IPv6 address.
        /// </summary>
        /// <remarks>
        /// Returns a full IPv6 address string in colon-separated hexadecimal notation.
        /// </remarks>
        [OSAction(
            Description = "Generates a random IPv6 address.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Ipv6"
        )]
        string FakeIpv6(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random MAC address.
        /// </summary>
        /// <remarks>
        /// Returns a colon-separated MAC address string (e.g., "00:1A:2B:3C:4D:5E").
        /// </remarks>
        [OSAction(
            Description = "Generates a random MAC address.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "MacAddress"
        )]
        string FakeMacAddress(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake password.
        /// </summary>
        /// <remarks>
        /// Generates a password containing a mix of lowercase letters, uppercase letters, digits, and special characters. The length parameter controls the total character count (default: 10, max: 100,000).
        /// </remarks>
        /// <example>
        /// <code>
        /// string password = fakeInternet.FakePassword(length: 16, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake password of the specified length.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Password"
        )]
        string FakePassword(
            [OSParameterAttribute(Description = "Password length. Default is 10.")]
            int length = 10,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random hex color code.
        /// </summary>
        /// <remarks>
        /// Returns a 6-character hex color string prefixed with # (e.g., "#a1b2c3").
        /// </remarks>
        [OSAction(
            Description = "Generates a random hex color code (e.g., #a1b2c3).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Color"
        )]
        string FakeColor(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a realistic user agent string.
        /// </summary>
        /// <remarks>
        /// Returns a browser user agent string resembling real browser identifiers (Chrome, Firefox, Safari, etc.).
        /// </remarks>
        [OSAction(
            Description = "Generates a realistic user agent string.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "UserAgent"
        )]
        string FakeUserAgent(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Text

        /// <summary>
        /// Generates a single lorem ipsum word.
        /// </summary>
        /// <remarks>
        /// Returns a single lorem ipsum word.
        /// </remarks>
        [OSAction(
            Description = "Generates a single lorem ipsum word.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Word"
        )]
        string FakeLoremWord(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates multiple lorem ipsum words joined by spaces.
        /// </summary>
        /// <remarks>
        /// Returns the specified number of lorem ipsum words joined by spaces. Count is capped at 10,000.
        /// </remarks>
        /// <example>
        /// <code>
        /// string words = fakeText.FakeLoremWords(count: 5, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates multiple lorem ipsum words joined by spaces.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Words"
        )]
        string FakeLoremWords(
            [OSParameterAttribute(Description = "Number of words to generate. Default is 3.")]
            int count = 3,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a lorem ipsum sentence.
        /// </summary>
        /// <remarks>
        /// The wordCount parameter is approximate — the actual sentence may have slightly more or fewer words. The sentence ends with a period.
        /// </remarks>
        [OSAction(
            Description = "Generates a lorem ipsum sentence.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Sentence"
        )]
        string FakeLoremSentence(
            [OSParameterAttribute(Description = "Approximate number of words. Default is 6.")]
            int wordCount = 6,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a lorem ipsum paragraph.
        /// </summary>
        /// <remarks>
        /// Returns a paragraph composed of multiple sentences.
        /// </remarks>
        [OSAction(
            Description = "Generates a lorem ipsum paragraph.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Paragraph"
        )]
        string FakeLoremParagraph(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates multiple lorem ipsum paragraphs separated by newlines.
        /// </summary>
        /// <remarks>
        /// Returns multiple paragraphs separated by newline characters. Count is capped at 10,000.
        /// </remarks>
        /// <example>
        /// <code>
        /// string text = fakeText.FakeLoremParagraphs(count: 3, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates multiple lorem ipsum paragraphs separated by newlines.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Paragraphs"
        )]
        string FakeLoremParagraphs(
            [OSParameterAttribute(Description = "Number of paragraphs. Default is 3.")]
            int count = 3,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a URL-friendly slug from lorem ipsum words.
        /// </summary>
        /// <remarks>
        /// Returns a URL-friendly slug with words separated by hyphens (e.g., "lorem-ipsum-dolor").
        /// </remarks>
        [OSAction(
            Description = "Generates a URL-friendly slug from lorem ipsum words.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Slug"
        )]
        string FakeLoremSlug(
            [OSParameterAttribute(Description = "Number of words in the slug. Default is 3.")]
            int wordCount = 3,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Commerce

        /// <summary>
        /// Generates a realistic product name.
        /// </summary>
        /// <remarks>
        /// Generates a product name composed of adjective, material, and product components (e.g., "Refined Steel Keyboard").
        /// </remarks>
        [OSAction(
            Description = "Generates a realistic product name.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "ProductName"
        )]
        string FakeProductName(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random product price as a formatted string.
        /// </summary>
        /// <remarks>
        /// Returns a price as a formatted string with two decimal places (e.g., "49.99"). The value falls between min and max.
        /// </remarks>
        /// <example>
        /// <code>
        /// string price = fakeCommerce.FakeProductPrice(min: 5, max: 100, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random product price as a formatted string.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "ProductPrice"
        )]
        string FakeProductPrice(
            [OSParameterAttribute(Description = "Minimum price. Default is 1.")]
            decimal min = 1,
            [OSParameterAttribute(Description = "Maximum price. Default is 1000.")]
            decimal max = 1000,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random department name.
        /// </summary>
        /// <remarks>
        /// Returns a retail department name (e.g., "Electronics", "Clothing", "Sports").
        /// </remarks>
        [OSAction(
            Description = "Returns a random department name.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Department"
        )]
        string FakeDepartment(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random product category.
        /// </summary>
        /// <remarks>
        /// Returns a product category within retail departments.
        /// </remarks>
        [OSAction(
            Description = "Returns a random product category.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Category"
        )]
        string FakeProductCategory(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake EAN-13 barcode.
        /// </summary>
        /// <remarks>
        /// Generates a valid 13-digit European Article Number barcode string.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake EAN-13 barcode.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Ean13"
        )]
        string FakeEan13(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake EAN-8 barcode.
        /// </summary>
        /// <remarks>
        /// Generates a valid 8-digit European Article Number barcode string (compact format).
        /// </remarks>
        [OSAction(
            Description = "Generates a fake EAN-8 barcode.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Ean8"
        )]
        string FakeEan8(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Date

        /// <summary>
        /// Generates a random date in the past.
        /// </summary>
        /// <remarks>
        /// Generates a date between now and N years ago. Use this for dates in the distant past. For dates within the last few days, use <see cref="FakeRecentDate"/> instead.
        /// </remarks>
        /// <example>
        /// <code>
        /// DateTime pastDate = fakeDate.FakePastDate(yearsToGoBack: 5, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random date in the past.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "PastDate"
        )]
        DateTime FakePastDate(
            [OSParameterAttribute(Description = "Number of years to go back. Default is 1.")]
            int yearsToGoBack = 1,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random date in the future.
        /// </summary>
        /// <remarks>
        /// Generates a date between now and N years from now. Use this for dates in the distant future. For dates within the next few days, use <see cref="FakeSoonDate"/> instead.
        /// </remarks>
        /// <example>
        /// <code>
        /// DateTime futureDate = fakeDate.FakeFutureDate(yearsToGoForward: 2, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random date in the future.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "FutureDate"
        )]
        DateTime FakeFutureDate(
            [OSParameterAttribute(Description = "Number of years to go forward. Default is 1.")]
            int yearsToGoForward = 1,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random date between two dates.
        /// </summary>
        /// <remarks>
        /// Both start and end dates are inclusive. If start equals end, that exact date is returned. The start date must not be after the end date.
        /// </remarks>
        /// <example>
        /// <code>
        /// DateTime date = fakeDate.FakeDateBetween(
        ///     new DateTime(2020, 1, 1),
        ///     new DateTime(2025, 12, 31),
        ///     seed: 42
        /// );
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random date between the specified start and end dates.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "DateBetween"
        )]
        DateTime FakeDateBetween(
            [OSParameterAttribute(Description = "Start date (inclusive).")]
            DateTime start,
            [OSParameterAttribute(Description = "End date (inclusive).")]
            DateTime end,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random recent date within the specified number of days.
        /// </summary>
        /// <remarks>
        /// Generates a date within the last N days from now. For example, days=7 returns a date from the past week. For longer time spans, use <see cref="FakePastDate"/> instead.
        /// </remarks>
        /// <example>
        /// <code>
        /// DateTime recent = fakeDate.FakeRecentDate(days: 7, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random recent date within the specified number of days in the past.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "RecentDate"
        )]
        DateTime FakeRecentDate(
            [OSParameterAttribute(Description = "Number of days in the past. Default is 1.")]
            int days = 1,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random upcoming date within the specified number of days.
        /// </summary>
        /// <remarks>
        /// Generates a date within the next N days from now. For example, days=7 returns a date in the next week. For longer time spans, use <see cref="FakeFutureDate"/> instead.
        /// </remarks>
        /// <example>
        /// <code>
        /// DateTime soon = fakeDate.FakeSoonDate(days: 3, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random upcoming date within the specified number of days in the future.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "SoonDate"
        )]
        DateTime FakeSoonDate(
            [OSParameterAttribute(Description = "Number of days in the future. Default is 1.")]
            int days = 1,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region System

        /// <summary>
        /// Generates a realistic file name with extension.
        /// </summary>
        /// <remarks>
        /// Returns a file name with a realistic extension (e.g., "report.pdf", "image.jpg").
        /// </remarks>
        /// <example>
        /// <code>
        /// string fileName = fakeSystem.FakeFileName("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a realistic file name with extension.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "FileName"
        )]
        string FakeFileName(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random MIME type.
        /// </summary>
        /// <remarks>
        /// Returns a MIME type string in type/subtype format (e.g., "application/json", "image/png").
        /// </remarks>
        [OSAction(
            Description = "Returns a random MIME type (e.g., application/json).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "MimeType"
        )]
        string FakeMimeType(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Returns a random file extension.
        /// </summary>
        /// <remarks>
        /// Returns a file extension without the leading dot (e.g., "pdf", "jpg", "csv").
        /// </remarks>
        [OSAction(
            Description = "Returns a random file extension (e.g., pdf, jpg).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "FileExtension"
        )]
        string FakeFileExtension(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random semantic version string.
        /// </summary>
        /// <remarks>
        /// Returns a semantic version string in major.minor.patch format (e.g., "1.2.3").
        /// </remarks>
        [OSAction(
            Description = "Generates a random semantic version string (e.g., 1.2.3).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Semver"
        )]
        string FakeSemver(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Randomizer

        /// <summary>
        /// Generates a random GUID string.
        /// </summary>
        /// <remarks>
        /// Returns a GUID string in the standard 8-4-4-4-12 format (e.g., "550e8400-e29b-41d4-a716-446655440000").
        /// </remarks>
        /// <example>
        /// <code>
        /// string guid = fakeRandomizer.FakeGuid(seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random GUID string.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Guid"
        )]
        string FakeGuid(
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random integer within the specified range.
        /// </summary>
        /// <remarks>
        /// Both min and max are inclusive. Defaults to range 0-100.
        /// </remarks>
        /// <example>
        /// <code>
        /// int roll = fakeRandomizer.FakeNumber(min: 1, max: 6, seed: 42); // dice roll
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random integer within the specified range.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Number"
        )]
        int FakeNumber(
            [OSParameterAttribute(Description = "Minimum value (inclusive). Default is 0.")]
            int min = 0,
            [OSParameterAttribute(Description = "Maximum value (inclusive). Default is 100.")]
            int max = 100,
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random decimal within the specified range.
        /// </summary>
        /// <remarks>
        /// Both min and max are inclusive. Defaults to range 0-100.
        /// </remarks>
        [OSAction(
            Description = "Generates a random decimal within the specified range.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Value"
        )]
        decimal FakeDecimal(
            [OSParameterAttribute(Description = "Minimum value (inclusive). Default is 0.")]
            decimal min = 0,
            [OSParameterAttribute(Description = "Maximum value (inclusive). Default is 100.")]
            decimal max = 100,
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a random boolean with configurable probability.
        /// </summary>
        /// <remarks>
        /// The weight parameter controls the probability of returning true (0.0 = always false, 1.0 = always true, 0.5 = equal chance). Default is 0.5.
        /// </remarks>
        /// <example>
        /// <code>
        /// bool coin = fakeRandomizer.FakeBoolean(weight: 0.5m, seed: 42);
        /// bool biased = fakeRandomizer.FakeBoolean(weight: 0.8m, seed: 42); // 80% true
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a random boolean with configurable probability weight for true.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Value"
        )]
        bool FakeBoolean(
            [OSParameterAttribute(Description = "Probability weight for true (0.0 to 1.0). Default is 0.5.")]
            decimal weight = 0.5m,
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake hex hash string.
        /// </summary>
        /// <remarks>
        /// Returns a lowercase hexadecimal string of the specified length. Default length is 40 (SHA-1 length). Length is capped at 100,000.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake lowercase hex hash string.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Hash"
        )]
        string FakeHash(
            [OSParameterAttribute(Description = "Length of the hash string. Default is 40.")]
            int length = 40,
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake alphanumeric string.
        /// </summary>
        /// <remarks>
        /// Returns a string containing only lowercase letters (a-z) and digits (0-9). Default length is 10. Length is capped at 100,000.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake alphanumeric string of the specified length.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "AlphaNumeric"
        )]
        string FakeAlphaNumeric(
            [OSParameterAttribute(Description = "Length of the string. Default is 10.")]
            int length = 10,
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion

        #region Bulk Generation

        /// <summary>
        /// Generates a list of complete fictional persons with all identity fields populated.
        /// </summary>
        /// <remarks>
        /// Each person in the list has independently generated FirstName, LastName, FullName, Email, Phone, DateOfBirth, UserName, JobTitle, and Gender. More efficient than calling GenerateFakePerson in a loop.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of complete fictional persons.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Persons"
        )]
        List<FakePersonData> GenerateFakePersons(
            [OSParameterAttribute(Description = "Number of persons to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of fake email addresses.
        /// </summary>
        /// <remarks>
        /// Each email in the list is independently generated. The domains may be real (e.g., gmail.com, yahoo.com).
        /// </remarks>
        [OSAction(
            Description = "Generates a list of fake email addresses.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Emails"
        )]
        List<string> FakeEmails(
            [OSParameterAttribute(Description = "Number of emails to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of realistic full addresses.
        /// </summary>
        /// <remarks>
        /// Each address includes street number, street name, city, state, and zip code.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of realistic full addresses.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Addresses"
        )]
        List<string> FakeFullAddresses(
            [OSParameterAttribute(Description = "Number of addresses to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of realistic company names.
        /// </summary>
        /// <remarks>
        /// Each company name is generated using locale-appropriate patterns.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of realistic company names.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "CompanyNames"
        )]
        List<string> FakeCompanyNames(
            [OSParameterAttribute(Description = "Number of company names to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of random monetary amounts within the specified range.
        /// </summary>
        /// <remarks>
        /// Each amount is a decimal value between min and max with the specified number of decimal places.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of random monetary amounts within the specified range.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Amounts"
        )]
        List<decimal> FakeAmounts(
            [OSParameterAttribute(Description = "Number of amounts to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Minimum amount. Default is 0.")]
            decimal min = 0,
            [OSParameterAttribute(Description = "Maximum amount. Default is 1000.")]
            decimal max = 1000,
            [OSParameterAttribute(Description = "Number of decimal places. Default is 2.")]
            int decimals = 2,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of fake URLs.
        /// </summary>
        /// <remarks>
        /// Each URL has a plausible protocol, domain, and path. The domains may be real.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of fake URLs.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Urls"
        )]
        List<string> FakeUrls(
            [OSParameterAttribute(Description = "Number of URLs to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of lorem ipsum sentences.
        /// </summary>
        /// <remarks>
        /// Each sentence has approximately the specified word count and ends with a period.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of lorem ipsum sentences.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Sentences"
        )]
        List<string> FakeLoremSentences(
            [OSParameterAttribute(Description = "Number of sentences to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Approximate number of words per sentence. Default is 6.")]
            int wordCount = 6,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of realistic product names.
        /// </summary>
        /// <remarks>
        /// Each product name is composed of adjective, material, and product components.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of realistic product names.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "ProductNames"
        )]
        List<string> FakeProductNames(
            [OSParameterAttribute(Description = "Number of product names to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of random dates in the past.
        /// </summary>
        /// <remarks>
        /// Each date falls between now and N years ago.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of random dates in the past.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "PastDates"
        )]
        List<DateTime> FakePastDates(
            [OSParameterAttribute(Description = "Number of dates to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Number of years to go back. Default is 1.")]
            int yearsToGoBack = 1,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of random integers within the specified range.
        /// </summary>
        /// <remarks>
        /// Both min and max are inclusive. Defaults to range 0-100.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of random integers within the specified range.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Numbers"
        )]
        List<int> FakeNumbers(
            [OSParameterAttribute(Description = "Number of integers to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Minimum value (inclusive). Default is 0.")]
            int min = 0,
            [OSParameterAttribute(Description = "Maximum value (inclusive). Default is 100.")]
            int max = 100,
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a list of random GUID strings.
        /// </summary>
        /// <remarks>
        /// Each GUID is in the standard 8-4-4-4-12 format.
        /// </remarks>
        [OSAction(
            Description = "Generates a list of random GUID strings.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Guids"
        )]
        List<string> FakeGuids(
            [OSParameterAttribute(Description = "Number of GUIDs to generate. Default is 10.")]
            int count = 10,
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        #endregion
    }
}
