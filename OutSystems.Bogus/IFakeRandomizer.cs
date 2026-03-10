using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Provides randomizer utility actions using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Provides randomizer utilities (GUIDs, numbers, booleans, hashes, alphanumeric strings) using the Bogus library.",
        Name = "FakeRandomizer",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeRandomizer
    {
        /// <summary>
        /// Generates a fake GUID string.
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
            Description = "Generates a fake GUID string.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Guid"
        )]
        string FakeGuid(
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake integer within the specified range.
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
            Description = "Generates a fake integer within the specified range.",
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
        /// Generates a fake decimal within the specified range.
        /// </summary>
        /// <remarks>
        /// Both min and max are inclusive. Defaults to range 0-100.
        /// </remarks>
        [OSAction(
            Description = "Generates a fake decimal within the specified range.",
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
        /// Generates a fake boolean with configurable probability.
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
            Description = "Generates a fake boolean with configurable probability weight for true.",
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
    }
}
