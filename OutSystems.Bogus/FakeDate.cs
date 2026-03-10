namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeDate. Generates fake date and time data.
    /// </summary>
    public class FakeDate : IFakeDate
    {
        public DateTime FakePastDate(int yearsToGoBack = 1, string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Past(yearsToGoBack);
        }

        public DateTime FakeFutureDate(int yearsToGoForward = 1, string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Future(yearsToGoForward);
        }

        public DateTime FakeDateBetween(DateTime start, DateTime end, string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Between(start, end);
        }

        public DateTime FakeRecentDate(int days = 1, string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Recent(days);
        }

        public DateTime FakeSoonDate(int days = 1, string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Soon(days);
        }
    }
}
