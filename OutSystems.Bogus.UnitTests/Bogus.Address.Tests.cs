using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeAddress actions: full address, city, country, zip code,
    /// state, street address, latitude, and longitude.
    /// </summary>
    [TestFixture]
    public class FakeAddressTests
    {
        private readonly FakeAddress _sut = new();

        #region Seed Determinism Helper

        private static void AssertDeterministic(Func<int, string> action, int seed = 12345)
        {
            var result1 = action(seed);
            var result2 = action(seed);
            Assert.That(result2, Is.EqualTo(result1));
        }

        #endregion

        #region FakeFullAddress Tests

        [Test]
        public void FakeFullAddress_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeFullAddress(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeFullAddress_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakeFullAddress("en", s));
        }

        #endregion

        #region FakeCity Tests

        [Test]
        public void FakeCity_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeCity(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeCity_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakeCity("en", s));
        }

        #endregion

        #region FakeCountry Tests

        [Test]
        public void FakeCountry_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeCountry(), Is.Not.Null.And.Not.Empty);
        }

        #endregion

        #region FakeCountryCode Tests

        [Test]
        public void FakeCountryCode_DefaultParams_ReturnsTwoLetterCode()
        {
            var result = _sut.FakeCountryCode();
            Assert.That(result, Has.Length.EqualTo(2));
        }

        #endregion

        #region FakeZipCode Tests

        [Test]
        public void FakeZipCode_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeZipCode(), Is.Not.Null.And.Not.Empty);
        }

        #endregion

        #region FakeState Tests

        [Test]
        public void FakeState_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeState(), Is.Not.Null.And.Not.Empty);
        }

        #endregion

        #region FakeStreetAddress Tests

        [Test]
        public void FakeStreetAddress_DefaultParams_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeStreetAddress(), Is.Not.Null.And.Not.Empty);
        }

        #endregion

        #region FakeLatitude / FakeLongitude Tests

        [Test]
        public void FakeLatitude_ReturnsValueInRange()
        {
            var result = _sut.FakeLatitude();
            Assert.That(result, Is.InRange(-90m, 90m));
        }

        [Test]
        public void FakeLongitude_ReturnsValueInRange()
        {
            var result = _sut.FakeLongitude();
            Assert.That(result, Is.InRange(-180m, 180m));
        }

        [Test]
        public void FakeLatitude_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeLatitude(42);
            var r2 = _sut.FakeLatitude(42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        [Test]
        public void FakeLongitude_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeLongitude(42);
            var r2 = _sut.FakeLongitude(42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        // --- Branch coverage: locale fallback ---

        [Test]
        public void FakeCity_NullLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeCity(null!, 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeCity_EmptyLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeCity("", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeCity_WhitespaceLocale_FallsBackToEnglish()
        {
            var result = _sut.FakeCity("  ", 42);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        // --- Branch coverage: seed=0 random path ---

        [Test]
        public void FakeCity_SeedZero_ReturnsNonEmpty()
        {
            var result = _sut.FakeCity("en", 0);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLatitude_SeedZero_ReturnsValueInRange()
        {
            var result = _sut.FakeLatitude(0);
            Assert.That(result, Is.InRange(-90m, 90m));
        }

        [Test]
        public void FakeLongitude_SeedZero_ReturnsValueInRange()
        {
            var result = _sut.FakeLongitude(0);
            Assert.That(result, Is.InRange(-180m, 180m));
        }
    }
}
