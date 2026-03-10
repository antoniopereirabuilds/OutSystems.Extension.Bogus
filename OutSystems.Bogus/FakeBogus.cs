namespace OutSystems.Bogus
{
    /// <summary>
    /// Unified implementation of IFakeBogus. Generates all categories of fake data.
    /// </summary>
    public class FakeBogus : IFakeBogus
    {
        #region Person

        public string FakeFirstName(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Name.FirstName();
        }

        public string FakeLastName(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Name.LastName();
        }

        public string FakeFullName(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Name.FullName();
        }

        public string FakeEmail(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.Email();
        }

        public string FakeUserName(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Internet.UserName();
        }

        public string FakePhoneNumber(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Phone.PhoneNumber();
        }

        public DateTime FakeDateOfBirth(int minAge = 18, int maxAge = 65, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidatePositive(minAge, nameof(minAge));
            FakerHelper.ValidatePositive(maxAge, nameof(maxAge));
            FakerHelper.ValidateRange(minAge, maxAge, nameof(minAge), nameof(maxAge));
            var faker = FakerHelper.CreateFaker(locale, seed);
            var now = DateTime.UtcNow;
            return faker.Date.Between(
                now.AddYears(-maxAge),
                now.AddYears(-minAge)
            );
        }

        public string FakeJobTitle(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Name.JobTitle();
        }

        public FakePersonData GenerateFakePerson(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            var person = faker.Person;
            return new FakePersonData
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                FullName = person.FullName,
                Email = person.Email,
                Phone = person.Phone,
                DateOfBirth = person.DateOfBirth,
                UserName = person.UserName,
                JobTitle = faker.Name.JobTitle(),
                Gender = person.Gender.ToString()
            };
        }

        #endregion

        #region Address

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

        #endregion

        #region Company

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

        #endregion

        #region Finance

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
            FakerHelper.ValidateRange(min, max, nameof(min), nameof(max));
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

        #endregion

        #region Internet

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

        #endregion

        #region Text

        public string FakeLoremWord(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Lorem.Word();
        }

        public string FakeLoremWords(int count = 3, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidateCount(count, nameof(count));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return string.Join(" ", faker.Lorem.Words(count));
        }

        public string FakeLoremSentence(int wordCount = 6, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidateCount(wordCount, nameof(wordCount));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Lorem.Sentence(wordCount);
        }

        public string FakeLoremParagraph(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Lorem.Paragraph();
        }

        public string FakeLoremParagraphs(int count = 3, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidateCount(count, nameof(count));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Lorem.Paragraphs(count);
        }

        public string FakeLoremSlug(int wordCount = 3, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidateCount(wordCount, nameof(wordCount));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Lorem.Slug(wordCount);
        }

        #endregion

        #region Commerce

        public string FakeProductName(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Commerce.ProductName();
        }

        public string FakeProductPrice(decimal min = 1, decimal max = 1000, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidateRange(min, max, nameof(min), nameof(max));
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

        #endregion

        #region Date

        public DateTime FakePastDate(int yearsToGoBack = 1, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidatePositive(yearsToGoBack, nameof(yearsToGoBack));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Past(yearsToGoBack);
        }

        public DateTime FakeFutureDate(int yearsToGoForward = 1, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidatePositive(yearsToGoForward, nameof(yearsToGoForward));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Future(yearsToGoForward);
        }

        public DateTime FakeDateBetween(DateTime start, DateTime end, string locale = "en", int seed = 0)
        {
            if (start > end)
                throw new ArgumentOutOfRangeException(nameof(start), start, "start must not be after end.");
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Between(start, end);
        }

        public DateTime FakeRecentDate(int days = 1, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidatePositive(days, nameof(days));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Recent(days);
        }

        public DateTime FakeSoonDate(int days = 1, string locale = "en", int seed = 0)
        {
            FakerHelper.ValidatePositive(days, nameof(days));
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Soon(days);
        }

        #endregion

        #region System

        public string FakeFileName(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.System.FileName();
        }

        public string FakeMimeType(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.System.MimeType();
        }

        public string FakeFileExtension(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.System.FileExt();
        }

        public string FakeSemver(string locale = "en", int seed = 0)
        {
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.System.Semver();
        }

        #endregion

        #region Randomizer

        public string FakeGuid(int seed = 0)
        {
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Guid().ToString();
        }

        public int FakeNumber(int min = 0, int max = 100, int seed = 0)
        {
            FakerHelper.ValidateRange(min, max, nameof(min), nameof(max));
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Number(min, max);
        }

        public decimal FakeDecimal(decimal min = 0, decimal max = 100, int seed = 0)
        {
            FakerHelper.ValidateRange(min, max, nameof(min), nameof(max));
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Decimal(min, max);
        }

        public bool FakeBoolean(decimal weight = 0.5m, int seed = 0)
        {
            if (weight < 0m || weight > 1m)
                throw new ArgumentOutOfRangeException(nameof(weight), weight, "weight must be between 0.0 and 1.0.");
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Bool((float)weight);
        }

        public string FakeHash(int length = 40, int seed = 0)
        {
            FakerHelper.ValidateLength(length, nameof(length));
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.Hash(length);
        }

        public string FakeAlphaNumeric(int length = 10, int seed = 0)
        {
            FakerHelper.ValidateLength(length, nameof(length));
            var randomizer = FakerHelper.CreateRandomizer(seed);
            return randomizer.AlphaNumeric(length);
        }

        #endregion
    }
}
