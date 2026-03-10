using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeText actions: word, words, sentence, paragraph, paragraphs, slug.
    /// </summary>
    [TestFixture]
    public class FakeTextTests
    {
        private readonly FakeText _sut = new();

        [Test]
        public void FakeLoremWord_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeLoremWord(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLoremWords_DefaultCount_ReturnsThreeWords()
        {
            var result = _sut.FakeLoremWords();
            var words = result.Split(' ');
            Assert.That(words, Has.Length.EqualTo(3));
        }

        [Test]
        public void FakeLoremWords_CustomCount_ReturnsCorrectCount()
        {
            var result = _sut.FakeLoremWords(5, seed: 42);
            var words = result.Split(' ');
            Assert.That(words, Has.Length.EqualTo(5));
        }

        [Test]
        public void FakeLoremSentence_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeLoremSentence(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLoremSentence_EndsWithPeriod()
        {
            var result = _sut.FakeLoremSentence();
            Assert.That(result, Does.EndWith("."));
        }

        [Test]
        public void FakeLoremParagraph_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeLoremParagraph(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLoremParagraphs_DefaultCount_ReturnsMultipleParagraphs()
        {
            var result = _sut.FakeLoremParagraphs();
            Assert.That(result, Does.Contain("\n"));
        }

        [Test]
        public void FakeLoremSlug_DefaultCount_ReturnsHyphenated()
        {
            var result = _sut.FakeLoremSlug();
            var parts = result.Split('-');
            Assert.That(parts, Has.Length.EqualTo(3));
        }

        [Test]
        public void FakeLoremWord_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeLoremWord(seed: 42);
            var r2 = _sut.FakeLoremWord(seed: 42);
            Assert.That(r2, Is.EqualTo(r1));
        }
    }
}
