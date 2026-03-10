using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeRandomizer actions: GUID, number, decimal, boolean, hash, alphanumeric.
    /// </summary>
    [TestFixture]
    public class FakeRandomizerTests
    {
        private readonly FakeRandomizer _sut = new();

        #region FakeGuid Tests

        [Test]
        public void FakeGuid_ReturnsValidGuidFormat()
        {
            var result = _sut.FakeGuid();
            Assert.That(Guid.TryParse(result, out _), Is.True);
        }

        [Test]
        public void FakeGuid_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeGuid(42);
            var r2 = _sut.FakeGuid(42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        #region FakeNumber Tests

        [Test]
        public void FakeNumber_DefaultRange_ReturnsValueInRange()
        {
            var result = _sut.FakeNumber();
            Assert.That(result, Is.InRange(0, 100));
        }

        [Test]
        public void FakeNumber_CustomRange_ReturnsValueInRange()
        {
            var result = _sut.FakeNumber(50, 60, 42);
            Assert.That(result, Is.InRange(50, 60));
        }

        #endregion

        #region FakeDecimal Tests

        [Test]
        public void FakeDecimal_DefaultRange_ReturnsValueInRange()
        {
            var result = _sut.FakeDecimal();
            Assert.That(result, Is.InRange(0m, 100m));
        }

        [Test]
        public void FakeDecimal_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeDecimal(0, 100, 42);
            var r2 = _sut.FakeDecimal(0, 100, 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        #region FakeBoolean Tests

        [Test]
        public void FakeBoolean_Weight1_AlwaysTrue()
        {
            var result = _sut.FakeBoolean(1.0m, 42);
            Assert.That(result, Is.True);
        }

        [Test]
        public void FakeBoolean_Weight0_AlwaysFalse()
        {
            var result = _sut.FakeBoolean(0.0m, 42);
            Assert.That(result, Is.False);
        }

        #endregion

        #region FakeHash Tests

        [Test]
        public void FakeHash_DefaultLength_ReturnsFortyChars()
        {
            var result = _sut.FakeHash();
            Assert.That(result, Has.Length.EqualTo(40));
        }

        [Test]
        public void FakeHash_CustomLength_ReturnsCorrectLength()
        {
            var result = _sut.FakeHash(20, 42);
            Assert.That(result, Has.Length.EqualTo(20));
        }

        #endregion

        #region FakeAlphaNumeric Tests

        [Test]
        public void FakeAlphaNumeric_DefaultLength_ReturnsTenChars()
        {
            var result = _sut.FakeAlphaNumeric();
            Assert.That(result, Has.Length.EqualTo(10));
        }

        [Test]
        public void FakeAlphaNumeric_CustomLength_ReturnsCorrectLength()
        {
            var result = _sut.FakeAlphaNumeric(25, 42);
            Assert.That(result, Has.Length.EqualTo(25));
        }

        [Test]
        public void FakeAlphaNumeric_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeAlphaNumeric(10, 42);
            var r2 = _sut.FakeAlphaNumeric(10, 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion
    }
}
