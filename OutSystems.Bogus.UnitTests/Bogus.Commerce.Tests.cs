using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeCommerce actions: product name, price, department, category, EAN-13, EAN-8.
    /// </summary>
    [TestFixture]
    public class FakeCommerceTests
    {
        private readonly FakeBogus _sut = new();

        [Test]
        public void FakeProductName_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeProductName(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeProductPrice_DefaultRange_ReturnsNonEmpty()
        {
            var result = _sut.FakeProductPrice();
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            Assert.That(decimal.TryParse(result, out var price), Is.True);
            Assert.That(price, Is.InRange(1m, 1000m));
        }

        [Test]
        public void FakeProductPrice_CustomRange_ReturnsValueInRange()
        {
            var result = _sut.FakeProductPrice(10, 50, seed: 42);
            Assert.That(decimal.Parse(result), Is.InRange(10m, 50m));
        }

        [Test]
        public void FakeDepartment_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeDepartment(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeProductCategory_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeProductCategory(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeEan13_ReturnsThirteenDigits()
        {
            var result = _sut.FakeEan13();
            Assert.That(result, Has.Length.EqualTo(13));
        }

        [Test]
        public void FakeEan8_ReturnsEightDigits()
        {
            var result = _sut.FakeEan8();
            Assert.That(result, Has.Length.EqualTo(8));
        }

        [Test]
        public void FakeProductName_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeProductName(seed: 42);
            var r2 = _sut.FakeProductName(seed: 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        // --- Branch coverage: locale fallback ---

        [Test]
        public void FakeProductName_NullLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeProductName(null!, 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeProductName_EmptyLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeProductName("", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeProductName_WhitespaceLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeProductName("  ", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        // --- Branch coverage: seed=0 random path ---

        [Test]
        public void FakeProductName_SeedZero_ReturnsNonEmpty()
        {
            var result = _sut.FakeProductName("en", 0);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }
    }
}
