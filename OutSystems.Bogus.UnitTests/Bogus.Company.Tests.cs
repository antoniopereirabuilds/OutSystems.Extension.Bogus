using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeCompany actions: company name, suffix, catch phrase, and BS.
    /// </summary>
    [TestFixture]
    public class FakeCompanyTests
    {
        private readonly FakeBogus _sut = new();

        [Test]
        public void FakeCompanyName_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeCompanyName(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeCompanyName_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeCompanyName("en", 42);
            var r2 = _sut.FakeCompanyName("en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        [Test]
        public void FakeCompanySuffix_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeCompanySuffix(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeCatchPhrase_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeCatchPhrase(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeBs_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeBs(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeBs_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeBs("en", 42);
            var r2 = _sut.FakeBs("en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        // --- Branch coverage: locale fallback ---

        [Test]
        public void FakeCompanyName_NullLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeCompanyName(null!, 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeCompanyName_EmptyLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeCompanyName("", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeCompanyName_WhitespaceLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeCompanyName("  ", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        // --- Branch coverage: seed=0 random path ---

        [Test]
        public void FakeCompanyName_SeedZero_ReturnsNonEmpty()
        {
            var result = _sut.FakeCompanyName("en", 0);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }
    }
}
