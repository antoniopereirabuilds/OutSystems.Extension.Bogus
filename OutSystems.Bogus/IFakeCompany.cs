using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake company and business data using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake company and business data (names, catch phrases, etc.) using the Bogus library.",
        Name = "FakeCompany",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeCompany
    {
        /// <summary>
        /// Generates a fake company name.
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
            Description = "Generates a fake company name.",
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
        /// Generates a fake company suffix (e.g., LLC, Inc).
        /// </summary>
        /// <remarks>
        /// Returns a business suffix such as "LLC", "Inc", "Group", or "Ltd" depending on locale.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake company suffix (e.g., LLC, Inc).",
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
        /// Generates a fake company catch phrase.
        /// </summary>
        /// <remarks>
        /// Generates a corporate-style catch phrase composed of adjective, descriptor, and noun components.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake company catch phrase.",
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
        /// Generates a fake company BS phrase.
        /// </summary>
        /// <remarks>
        /// Generates a corporate buzzword phrase (e.g., "synergize scalable platforms").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake company BS phrase.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Bs"
        )]
        string FakeBs(
            [OSParameterAttribute(Description = "Locale code. Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );
    }
}
