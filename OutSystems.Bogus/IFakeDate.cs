using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake date and time data using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake date and time data (past, future, recent, between) using the Bogus library.",
        Name = "FakeDate",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeDate
    {
        /// <summary>
        /// Generates a fake date in the past.
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
            Description = "Generates a fake date in the past.",
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
        /// Generates a fake date in the future.
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
            Description = "Generates a fake date in the future.",
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
        /// Generates a fake date between two dates.
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
            Description = "Generates a fake date between the specified start and end dates.",
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
        /// Generates a fake recent date within the specified number of days.
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
            Description = "Generates a fake recent date within the specified number of days in the past.",
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
        /// Generates a fake soon date within the specified number of days.
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
            Description = "Generates a fake soon date within the specified number of days in the future.",
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
    }
}
