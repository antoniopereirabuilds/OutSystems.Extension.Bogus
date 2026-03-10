using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeFinance actions: credit card, CVV, IBAN, BIC, amount,
    /// currency, and account number generation.
    /// </summary>
    [TestFixture]
    public class FakeFinanceTests
    {
        private readonly FakeBogus _sut = new();

        #region FakeCreditCardNumber Tests

        [Test]
        public void FakeCreditCardNumber_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeCreditCardNumber(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeCreditCardNumber_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeCreditCardNumber(seed: 42);
            var r2 = _sut.FakeCreditCardNumber(seed: 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        #region FakeCreditCardCvv Tests

        [Test]
        public void FakeCreditCardCvv_ReturnsThreeDigits()
        {
            var result = _sut.FakeCreditCardCvv();
            Assert.That(result, Has.Length.EqualTo(3));
        }

        #endregion

        #region FakeIban Tests

        [Test]
        public void FakeIban_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeIban(), Is.Not.Null.And.Not.Empty);
        }

        #endregion

        #region FakeBic Tests

        [Test]
        public void FakeBic_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeBic(), Is.Not.Null.And.Not.Empty);
        }

        #endregion

        #region FakeAmount Tests

        [Test]
        public void FakeAmount_DefaultRange_ReturnsValueInRange()
        {
            var result = _sut.FakeAmount();
            Assert.That(result, Is.InRange(0m, 1000m));
        }

        [Test]
        public void FakeAmount_CustomRange_ReturnsValueInRange()
        {
            var result = _sut.FakeAmount(50, 100, 2, seed: 42);
            Assert.That(result, Is.InRange(50m, 100m));
        }

        [Test]
        public void FakeAmount_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeAmount(0, 1000, 2, seed: 42);
            var r2 = _sut.FakeAmount(0, 1000, 2, seed: 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        [Test]
        public void FakeAmount_DecimalsNegative_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeAmount(0, 100, -1));
        }

        [Test]
        public void FakeAmount_DecimalsExceedsMax_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeAmount(0, 100, 11));
        }

        [Test]
        public void FakeAmount_MinGreaterThanMax_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeAmount(100, 10));
        }

        #endregion

        #region FakeCurrency Tests

        [Test]
        public void FakeCurrency_ReturnsPopulatedStruct()
        {
            var result = _sut.FakeCurrency();
            Assert.Multiple(() =>
            {
                Assert.That(result.Name, Is.Not.Null.And.Not.Empty);
                Assert.That(result.Code, Is.Not.Null.And.Not.Empty);
            });
        }

        [Test]
        public void FakeCurrency_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeCurrency(seed: 42);
            var r2 = _sut.FakeCurrency(seed: 42);
            Assert.That(r2.Code, Is.EqualTo(r1.Code));
        }

        #endregion

        #region FakeAccountNumber Tests

        [Test]
        public void FakeAccountNumber_ReturnsEightDigits()
        {
            var result = _sut.FakeAccountNumber();
            Assert.That(result, Has.Length.EqualTo(8));
        }

        #endregion

        // --- Branch coverage: locale fallback ---

        [Test]
        public void FakeIban_NullLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeIban(null!, 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeIban_EmptyLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeIban("", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeIban_WhitespaceLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeIban("  ", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        // --- Branch coverage: seed=0 random path ---

        [Test]
        public void FakeAmount_SeedZero_ReturnsValueInRange()
        {
            var result = _sut.FakeAmount(0, 1000, 2, "en", 0);
            Assert.That(result, Is.InRange(0m, 1000m));
        }

        [Test]
        public void FakeCurrency_SeedZero_ReturnsPopulatedCurrency()
        {
            var result = _sut.FakeCurrency("en", 0);
            Assert.That(result.Name, Is.Not.Null.And.Not.Empty);
            Assert.That(result.Code, Is.Not.Null.And.Not.Empty);
        }
    }
}
