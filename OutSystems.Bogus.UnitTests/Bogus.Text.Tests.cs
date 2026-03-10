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

        // --- Branch coverage: locale fallback ---

        [Test]
        public void FakeLoremWord_NullLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeLoremWord(null!, 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLoremWord_EmptyLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeLoremWord("", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLoremWord_WhitespaceLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeLoremWord("  ", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        // --- Branch coverage: seed=0 random path ---

        [Test]
        public void FakeLoremWord_SeedZero_ReturnsNonEmpty()
        {
            var result = _sut.FakeLoremWord("en", 0);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        // --- Branch coverage: ValidateCount boundaries ---

        [Test]
        public void FakeLoremWords_CountZero_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremWords(0));
        }

        [Test]
        public void FakeLoremWords_CountNegative_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremWords(-1));
        }

        [Test]
        public void FakeLoremWords_CountExceedsMax_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremWords(10_001));
        }

        [Test]
        public void FakeLoremWords_CountAtMinBoundary_ReturnsResult()
        {
            var result = _sut.FakeLoremWords(1, "en", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLoremParagraphs_CountZero_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremParagraphs(0));
        }

        [Test]
        public void FakeLoremParagraphs_CountNegative_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremParagraphs(-1));
        }

        [Test]
        public void FakeLoremParagraphs_CountExceedsMax_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremParagraphs(10_001));
        }

        [Test]
        public void FakeLoremParagraphs_CountAtMinBoundary_ReturnsResult()
        {
            var result = _sut.FakeLoremParagraphs(1, "en", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLoremSlug_CountZero_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSlug(0));
        }

        [Test]
        public void FakeLoremSlug_CountNegative_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSlug(-1));
        }

        [Test]
        public void FakeLoremSlug_CountExceedsMax_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSlug(10_001));
        }

        [Test]
        public void FakeLoremSentence_CountZero_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSentence(0));
        }

        [Test]
        public void FakeLoremSentence_CountNegative_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSentence(-1));
        }

        [Test]
        public void FakeLoremSentence_CountExceedsMax_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSentence(10_001));
        }
    }
}
