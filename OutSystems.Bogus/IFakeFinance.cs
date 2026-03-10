using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake financial data using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake financial data (credit cards, IBANs, amounts, currencies, etc.) using the Bogus library.",
        Name = "FakeFinance",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeFinance
    {
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
        /// Generates a fake monetary amount within the specified range.
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
            Description = "Generates a fake monetary amount within the specified range.",
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
        /// Generates a fake currency with name, code, and symbol.
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
            Description = "Generates a fake currency with name, code, and symbol.",
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
    }
}
