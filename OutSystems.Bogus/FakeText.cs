namespace OutSystems.Bogus
{
    /// <summary>
    /// Implementation of IFakeText. Generates fake text and lorem ipsum content.
    /// </summary>
    public class FakeText : IFakeText
    {
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
    }
}
