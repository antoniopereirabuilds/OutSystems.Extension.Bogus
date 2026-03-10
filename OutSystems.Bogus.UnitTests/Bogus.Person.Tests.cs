using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakePerson actions: first name, last name, full name, email,
    /// username, phone number, date of birth, job title, and full person generation.
    /// </summary>
    [TestFixture]
    public class FakePersonTests
    {
        private readonly FakePerson _sut = new();

        #region Seed Determinism Helpers

        private static void AssertDeterministic(Func<int, string> action, int seed = 12345)
        {
            var result1 = action(seed);
            var result2 = action(seed);
            Assert.That(result2, Is.EqualTo(result1), "Same seed should produce same result.");
        }

        #endregion

        #region FakeFirstName Tests

        [Test]
        public void FakeFirstName_DefaultParams_ReturnsNonEmpty()
        {
            var result = _sut.FakeFirstName();
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeFirstName_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakeFirstName("en", s));
        }

        [Test]
        public void FakeFirstName_DifferentLocale_ReturnsNonEmpty()
        {
            var result = _sut.FakeFirstName("fr");
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        #endregion

        #region FakeLastName Tests

        [Test]
        public void FakeLastName_DefaultParams_ReturnsNonEmpty()
        {
            var result = _sut.FakeLastName();
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeLastName_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakeLastName("en", s));
        }

        #endregion

        #region FakeFullName Tests

        [Test]
        public void FakeFullName_DefaultParams_ReturnsNonEmpty()
        {
            var result = _sut.FakeFullName();
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeFullName_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakeFullName("en", s));
        }

        [Test]
        public void FakeFullName_ContainsSpace()
        {
            var result = _sut.FakeFullName("en", 42);
            Assert.That(result, Does.Contain(" "));
        }

        #endregion

        #region FakeEmail Tests

        [Test]
        public void FakeEmail_DefaultParams_ContainsAtSign()
        {
            var result = _sut.FakeEmail();
            Assert.That(result, Does.Contain("@"));
        }

        [Test]
        public void FakeEmail_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakeEmail("en", s));
        }

        #endregion

        #region FakeUserName Tests

        [Test]
        public void FakeUserName_DefaultParams_ReturnsNonEmpty()
        {
            var result = _sut.FakeUserName();
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeUserName_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakeUserName("en", s));
        }

        #endregion

        #region FakePhoneNumber Tests

        [Test]
        public void FakePhoneNumber_DefaultParams_ReturnsNonEmpty()
        {
            var result = _sut.FakePhoneNumber();
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakePhoneNumber_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakePhoneNumber("en", s));
        }

        #endregion

        #region FakeDateOfBirth Tests

        [Test]
        public void FakeDateOfBirth_DefaultParams_ReturnsDateInRange()
        {
            var result = _sut.FakeDateOfBirth();
            var now = DateTime.UtcNow;
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.LessThan(now.AddYears(-18).AddDays(1)));
                Assert.That(result, Is.GreaterThan(now.AddYears(-65).AddDays(-1)));
            });
        }

        [Test]
        public void FakeDateOfBirth_CustomRange_ReturnsDateInRange()
        {
            var result = _sut.FakeDateOfBirth(25, 30, seed: 42);
            var now = DateTime.UtcNow;
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.LessThan(now.AddYears(-25).AddDays(1)));
                Assert.That(result, Is.GreaterThan(now.AddYears(-30).AddDays(-1)));
            });
        }

        #endregion

        #region FakeJobTitle Tests

        [Test]
        public void FakeJobTitle_DefaultParams_ReturnsNonEmpty()
        {
            var result = _sut.FakeJobTitle();
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeJobTitle_WithSeed_IsDeterministic()
        {
            AssertDeterministic(s => _sut.FakeJobTitle("en", s));
        }

        #endregion

        #region GenerateFakePerson Tests

        [Test]
        public void GenerateFakePerson_DefaultParams_ReturnsPopulatedStruct()
        {
            var result = _sut.GenerateFakePerson();
            Assert.Multiple(() =>
            {
                Assert.That(result.FirstName, Is.Not.Null.And.Not.Empty);
                Assert.That(result.LastName, Is.Not.Null.And.Not.Empty);
                Assert.That(result.FullName, Is.Not.Null.And.Not.Empty);
                Assert.That(result.Email, Does.Contain("@"));
                Assert.That(result.Phone, Is.Not.Null.And.Not.Empty);
                Assert.That(result.UserName, Is.Not.Null.And.Not.Empty);
                Assert.That(result.JobTitle, Is.Not.Null.And.Not.Empty);
                Assert.That(result.Gender, Is.Not.Null.And.Not.Empty);
                Assert.That(result.DateOfBirth, Is.Not.EqualTo(DateTime.MinValue));
            });
        }

        [Test]
        public void GenerateFakePerson_WithSeed_IsDeterministic()
        {
            var result1 = _sut.GenerateFakePerson("en", 42);
            var result2 = _sut.GenerateFakePerson("en", 42);
            Assert.Multiple(() =>
            {
                Assert.That(result2.FirstName, Is.EqualTo(result1.FirstName));
                Assert.That(result2.LastName, Is.EqualTo(result1.LastName));
                Assert.That(result2.Email, Is.EqualTo(result1.Email));
            });
        }

        #endregion
    }
}
