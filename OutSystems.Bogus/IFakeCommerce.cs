using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake commerce and product data using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake commerce and product data (names, prices, categories, EANs) using the Bogus library.",
        Name = "FakeCommerce",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeCommerce
    {
        /// <summary>
        /// Generates a fake product name.
        /// </summary>
        /// <remarks>
        /// Generates a product name composed of adjective, material, and product components (e.g., "Refined Steel Keyboard").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake product name.",
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
        /// Generates a fake product price as a formatted string.
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
            Description = "Generates a fake product price as a formatted string.",
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
        /// Generates a fake department name.
        /// </summary>
        /// <remarks>
        /// Returns a retail department name (e.g., "Electronics", "Clothing", "Sports").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake department name.",
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
        /// Generates a fake product category.
        /// </summary>
        /// <remarks>
        /// Returns a product category within retail departments.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake product category.",
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
    }
}
