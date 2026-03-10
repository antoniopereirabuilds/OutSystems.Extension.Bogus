namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeCommerce. Generates fake commerce and product data.
    /// </summary>
    public class FakeCommerce : IFakeCommerce
    {
        public string FakeProductName(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Commerce.ProductName();
        }

        public string FakeProductPrice(decimal min = 1, decimal max = 1000, string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Commerce.Price(min, max);
        }

        public string FakeDepartment(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Commerce.Department();
        }

        public string FakeProductCategory(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Commerce.Categories(1)[0];
        }

        public string FakeEan13(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Commerce.Ean13();
        }

        public string FakeEan8(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Commerce.Ean8();
        }
    }
}
