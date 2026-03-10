using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake internet and digital data using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake internet data (URLs, IPs, passwords, user agents, etc.) using the Bogus library.",
        Name = "FakeInternet",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeInternet
    {
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
        /// Generates a fake IPv4 address.
        /// </summary>
        /// <remarks>
        /// Returns a dotted-quad IPv4 address string (e.g., "192.168.1.100").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake IPv4 address.",
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
        /// Generates a fake IPv6 address.
        /// </summary>
        /// <remarks>
        /// Returns a full IPv6 address string in colon-separated hexadecimal notation.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake IPv6 address.",
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
        /// Generates a fake MAC address.
        /// </summary>
        /// <remarks>
        /// Returns a colon-separated MAC address string (e.g., "00:1A:2B:3C:4D:5E").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake MAC address.",
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
        /// Generates a fake hex color code.
        /// </summary>
        /// <remarks>
        /// Returns a 6-character hex color string prefixed with # (e.g., "#a1b2c3").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake hex color code (e.g., #a1b2c3).",
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
        /// Generates a fake user agent string.
        /// </summary>
        /// <remarks>
        /// Returns a browser user agent string resembling real browser identifiers (Chrome, Firefox, Safari, etc.).
        /// </remarks>
        [OSAction(
            Description = "Generates a fake user agent string.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "UserAgent"
        )]
        string FakeUserAgent(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );
    }
}
