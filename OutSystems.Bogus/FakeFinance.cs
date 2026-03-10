namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeFinance. Generates fake financial data.
    /// </summary>
    public class FakeFinance : IFakeFinance
    {
        public string FakeCreditCardNumber(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Finance.CreditCardNumber();
        }

        public string FakeCreditCardCvv(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Finance.CreditCardCvv();
        }

        public string FakeIban(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Finance.Iban();
        }

        public string FakeBic(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Finance.Bic();
        }

        public decimal FakeAmount(decimal min = 0, decimal max = 1000, int decimals = 2, string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Finance.Amount(min, max, decimals);
        }

        public FakeCurrencyData FakeCurrency(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            var currency = faker.Finance.Currency();
            return new FakeCurrencyData
            {
                Name = currency.Description,
                Code = currency.Code,
                Symbol = currency.Symbol ?? string.Empty
            };
        }

        public string FakeAccountNumber(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Finance.Account();
        }
    }
}
