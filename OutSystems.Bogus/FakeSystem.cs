namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeSystem. Generates fake system and file data.
    /// </summary>
    public class FakeSystem : IFakeSystem
    {
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
    }
}
