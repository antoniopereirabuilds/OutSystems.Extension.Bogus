namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakePerson. Generates fake person and identity data.
    /// </summary>
    public class FakePerson : IFakePerson
    {
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
            var faker = FakerHelper.CreateFaker(locale, seed);
            return faker.Date.Between(
                DateTime.UtcNow.AddYears(-maxAge),
                DateTime.UtcNow.AddYears(-minAge)
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
    }
}
