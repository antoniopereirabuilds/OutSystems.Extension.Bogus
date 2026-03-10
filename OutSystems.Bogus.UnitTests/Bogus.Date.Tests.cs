using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeDate actions: past, future, between, recent, and soon dates.
    /// </summary>
    [TestFixture]
    public class FakeDateTests
    {
        private readonly FakeDate _sut = new();

        #region FakePastDate Tests

        [Test]
        public void FakePastDate_DefaultParams_ReturnsDateInPast()
        {
            var result = _sut.FakePastDate();
            Assert.That(result, Is.LessThan(DateTime.UtcNow));
        }

        [Test]
        public void FakePastDate_WithSeed_IsDeterministic()
        {
            // Bogus Date.Past uses DateTime.Now as reference, so two calls with
            // the same seed produce slightly different results due to time passing.
            // We verify they are within 1 second of each other to confirm the seed works.
            var r1 = _sut.FakePastDate(1, seed: 42);
            var r2 = _sut.FakePastDate(1, seed: 42);
            Assert.That((r2 - r1).Duration(), Is.LessThan(TimeSpan.FromSeconds(1)));
        }

        #endregion

        #region FakeFutureDate Tests

        [Test]
        public void FakeFutureDate_DefaultParams_ReturnsDateInFuture()
        {
            var result = _sut.FakeFutureDate();
            Assert.That(result, Is.GreaterThan(DateTime.UtcNow));
        }

        #endregion

        #region FakeDateBetween Tests

        [Test]
        public void FakeDateBetween_ValidRange_ReturnsDateInRange()
        {
            var start = new DateTime(2020, 1, 1);
            var end = new DateTime(2023, 12, 31);
            var result = _sut.FakeDateBetween(start, end, seed: 42);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.GreaterThanOrEqualTo(start));
                Assert.That(result, Is.LessThanOrEqualTo(end));
            });
        }

        #endregion

        #region FakeRecentDate Tests

        [Test]
        public void FakeRecentDate_DefaultParams_ReturnsRecentDate()
        {
            var result = _sut.FakeRecentDate();
            Assert.That(result, Is.GreaterThan(DateTime.UtcNow.AddDays(-2)));
        }

        #endregion

        #region FakeSoonDate Tests

        [Test]
        public void FakeSoonDate_DefaultParams_ReturnsSoonDate()
        {
            var result = _sut.FakeSoonDate();
            Assert.That(result, Is.LessThan(DateTime.UtcNow.AddDays(2)));
        }

        #endregion
    }
}
