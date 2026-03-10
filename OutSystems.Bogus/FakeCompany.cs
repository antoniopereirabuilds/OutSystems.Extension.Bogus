namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeCompany. Generates fake company and business data.
    /// </summary>
    public class FakeCompany : IFakeCompany
    {
        public string FakeCompanyName(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Company.CompanyName();
        }

        public string FakeCompanySuffix(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Company.CompanySuffix();
        }

        public string FakeCatchPhrase(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Company.CatchPhrase();
        }

        public string FakeBs(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Company.Bs();
        }
    }
}
