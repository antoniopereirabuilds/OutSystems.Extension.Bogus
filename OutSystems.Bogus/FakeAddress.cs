namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeAddress. Generates fake address and location data.
    /// </summary>
    public class FakeAddress : IFakeAddress
    {
        public string FakeFullAddress(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Address.FullAddress();
        }

        public string FakeCity(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Address.City();
        }

        public string FakeCountry(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Address.Country();
        }

        public string FakeCountryCode(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Address.CountryCode();
        }

        public string FakeZipCode(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Address.ZipCode();
        }

        public string FakeState(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Address.State();
        }

        public string FakeStreetAddress(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Address.StreetAddress();
        }

        public decimal FakeLatitude(int seed = 0)
        {
            var faker = FakerHelper.CreateFaker("en", seed);
            return (decimal)faker.Address.Latitude();
        }

        public decimal FakeLongitude(int seed = 0)
        {
            var faker = FakerHelper.CreateFaker("en", seed);
            return (decimal)faker.Address.Longitude();
        }
    }
}
