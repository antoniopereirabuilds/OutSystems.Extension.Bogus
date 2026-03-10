using BogusLib = Bogus;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Shared helper for creating Faker instances with locale and seed support.
    /// </summary>
    internal static class FakerHelper
    {
        private const int MaxCount = 10_000;
        private const int MaxLength = 100_000;
        private const int MaxWordCount = 1_000;

        /// <summary>
        /// Creates a Bogus Faker instance configured with the given locale and seed.
        /// </summary>
        /// <param name="locale">Locale string (e.g., "en", "pt_BR"). Defaults to "en" if null or empty.</param>
        /// <param name="seed">Seed for deterministic output. 0 means random.</param>
        internal static BogusLib.Faker CreateFaker(string? locale, int seed)
        {
            var effectiveLocale = string.IsNullOrWhiteSpace(locale) ? "en" : locale;
            var faker = new BogusLib.Faker(effectiveLocale);
            if (seed > 0)
                faker.Random = new BogusLib.Randomizer(seed);
            return faker;
        }

        /// <summary>
        /// Creates a Bogus Randomizer configured with the given seed.
        /// </summary>
        /// <param name="seed">Seed for deterministic output. 0 means random.</param>
        internal static BogusLib.Randomizer CreateRandomizer(int seed)
        {
            return seed > 0 ? new BogusLib.Randomizer(seed) : new BogusLib.Randomizer();
        }

        /// <summary>
        /// Validates that a count parameter is within a safe range.
        /// </summary>
        internal static int ValidateCount(int count, string paramName)
        {
            if (count < 1)
                throw new ArgumentOutOfRangeException(paramName, count, $"{paramName} must be at least 1.");
            if (count > MaxCount)
                throw new ArgumentOutOfRangeException(paramName, count, $"{paramName} must not exceed {MaxCount}.");
            return count;
        }

        /// <summary>
        /// Validates that a length parameter is within a safe range.
        /// </summary>
        internal static int ValidateLength(int length, string paramName)
        {
            if (length < 1)
                throw new ArgumentOutOfRangeException(paramName, length, $"{paramName} must be at least 1.");
            if (length > MaxLength)
                throw new ArgumentOutOfRangeException(paramName, length, $"{paramName} must not exceed {MaxLength}.");
            return length;
        }

        /// <summary>
        /// Validates that min is not greater than max.
        /// </summary>
        internal static void ValidateRange(decimal min, decimal max, string minParamName = "min", string maxParamName = "max")
        {
            if (min > max)
                throw new ArgumentOutOfRangeException(minParamName, min, $"{minParamName} must not be greater than {maxParamName}.");
        }

        /// <summary>
        /// Validates that a positive integer parameter is at least 1.
        /// </summary>
        internal static void ValidatePositive(int value, string paramName)
        {
            if (value < 1)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be at least 1.");
        }

        /// <summary>
        /// Validates that a word count parameter is within a safe range.
        /// </summary>
        internal static int ValidateWordCount(int wordCount, string paramName)
        {
            if (wordCount < 1)
                throw new ArgumentOutOfRangeException(paramName, wordCount, $"{paramName} must be at least 1.");
            if (wordCount > MaxWordCount)
                throw new ArgumentOutOfRangeException(paramName, wordCount, $"{paramName} must not exceed {MaxWordCount}.");
            return wordCount;
        }

        /// <summary>
        /// Validates that a decimals parameter is within 0-10.
        /// </summary>
        internal static void ValidateDecimals(int decimals, string paramName)
        {
            if (decimals < 0 || decimals > 10)
                throw new ArgumentOutOfRangeException(paramName, decimals, $"{paramName} must be between 0 and 10.");
        }
    }
}
