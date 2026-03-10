namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeInternet. Generates fake internet and digital data.
    /// </summary>
    public class FakeInternet : IFakeInternet
    {
        public string FakeUrl(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.Url();
        }

        public string FakeIp(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.Ip();
        }

        public string FakeIpv6(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.Ipv6();
        }

        public string FakeMacAddress(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.Mac();
        }

        public string FakePassword(int length = 10, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidateLength(length, nameof(length));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.Password(length);
        }

        public string FakeColor(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.Color();
        }

        public string FakeUserAgent(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.UserAgent();
        }
    }
}
