using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake address and location data using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake address and location data (cities, countries, coordinates, etc.) using the Bogus library.",
        Name = "FakeAddress",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeAddress
    {
        /// <summary>
        /// Generates a fake full address.
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
            Description = "Generates a fake full address.",
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
        /// Generates a fake city name.
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
            Description = "Generates a fake city name.",
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
        /// Generates a fake country name.
        /// </summary>
        /// <remarks>
        /// Returns a full country name (e.g., "United States", "Brazil").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake country name.",
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
        /// Generates a fake country code (ISO 3166-1 alpha-2).
        /// </summary>
        /// <remarks>
        /// Returns an ISO 3166-1 alpha-2 code (e.g., "US", "BR", "DE").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake country code (ISO 3166-1 alpha-2).",
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
        /// Generates a fake state/province name.
        /// </summary>
        /// <remarks>
        /// Returns a state, province, or region name depending on the locale.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake state/province name.",
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
        /// Generates a fake street address.
        /// </summary>
        /// <remarks>
        /// Returns a street address with number and street name (e.g., "123 Main Street").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake street address.",
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
        /// Generates a fake latitude value.
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
            Description = "Generates a fake latitude value between -90 and 90.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Latitude"
        )]
        decimal FakeLatitude(
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake longitude value.
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
            Description = "Generates a fake longitude value between -180 and 180.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Longitude"
        )]
        decimal FakeLongitude(
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );
    }
}
