using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for bulk generation actions that return List&lt;T&gt;.
    /// </summary>
    [TestFixture]
    public class FakeBulkTests
    {
        private readonly FakeBogus _sut = new();

        #region GenerateFakePersons Tests

        [Test]
        public void GenerateFakePersons_ReturnsRequestedCount()
        {
            var result = _sut.GenerateFakePersons(count: 5, locale: "en", seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
        }

        [Test]
        public void GenerateFakePersons_AllFieldsPopulated()
        {
            var result = _sut.GenerateFakePersons(count: 3, locale: "en", seed: 42);
            Assert.Multiple(() =>
            {
                foreach (var p in result)
                {
                    Assert.That(p.FirstName, Is.Not.Null.And.Not.Empty);
                    Assert.That(p.LastName, Is.Not.Null.And.Not.Empty);
                    Assert.That(p.FullName, Is.Not.Null.And.Not.Empty);
                    Assert.That(p.Email, Is.Not.Null.And.Not.Empty);
                    Assert.That(p.Phone, Is.Not.Null.And.Not.Empty);
                    Assert.That(p.UserName, Is.Not.Null.And.Not.Empty);
                    Assert.That(p.JobTitle, Is.Not.Null.And.Not.Empty);
                    Assert.That(p.Gender, Is.Not.Null.And.Not.Empty);
                }
            });
        }

        [Test]
        public void GenerateFakePersons_WithSeed_IsDeterministic()
        {
            var result1 = _sut.GenerateFakePersons(3, "en", 42);
            var result2 = _sut.GenerateFakePersons(3, "en", 42);
            Assert.Multiple(() =>
            {
                Assert.That(result2[0].FirstName, Is.EqualTo(result1[0].FirstName));
                Assert.That(result2[2].Email, Is.EqualTo(result1[2].Email));
            });
        }

        [Test]
        public void GenerateFakePersons_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.GenerateFakePersons(count: 0));
        }

        #endregion

        #region FakeEmails Tests

        [Test]
        public void FakeEmails_ReturnsRequestedCount()
        {
            var result = _sut.FakeEmails(count: 5, locale: "en", seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.Contain("@"));
        }

        [Test]
        public void FakeEmails_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeEmails(3, "en", 42);
            var r2 = _sut.FakeEmails(3, "en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        [Test]
        public void FakeEmails_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeEmails(count: 0));
        }

        #endregion

        #region FakeFullAddresses Tests

        [Test]
        public void FakeFullAddresses_ReturnsRequestedCount()
        {
            var result = _sut.FakeFullAddresses(count: 5, locale: "en", seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.Not.Empty);
        }

        [Test]
        public void FakeFullAddresses_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeFullAddresses(3, "en", 42);
            var r2 = _sut.FakeFullAddresses(3, "en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        #region FakeCompanyNames Tests

        [Test]
        public void FakeCompanyNames_ReturnsRequestedCount()
        {
            var result = _sut.FakeCompanyNames(count: 5, locale: "en", seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.Not.Empty);
        }

        [Test]
        public void FakeCompanyNames_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeCompanyNames(3, "en", 42);
            var r2 = _sut.FakeCompanyNames(3, "en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        #region FakeAmounts Tests

        [Test]
        public void FakeAmounts_ReturnsRequestedCount()
        {
            var result = _sut.FakeAmounts(count: 5, min: 10, max: 500, decimals: 2, seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.InRange(10m, 500m));
        }

        [Test]
        public void FakeAmounts_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeAmounts(3, 0, 100, 2, "en", 42);
            var r2 = _sut.FakeAmounts(3, 0, 100, 2, "en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        [Test]
        public void FakeAmounts_MinGreaterThanMax_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeAmounts(count: 5, min: 100, max: 10));
        }

        #endregion

        #region FakeUrls Tests

        [Test]
        public void FakeUrls_ReturnsRequestedCount()
        {
            var result = _sut.FakeUrls(count: 5, locale: "en", seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.StartWith("http"));
        }

        [Test]
        public void FakeUrls_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeUrls(3, "en", 42);
            var r2 = _sut.FakeUrls(3, "en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        #region FakeLoremSentences Tests

        [Test]
        public void FakeLoremSentences_ReturnsRequestedCount()
        {
            var result = _sut.FakeLoremSentences(count: 5, wordCount: 6, locale: "en", seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.Not.Empty);
        }

        [Test]
        public void FakeLoremSentences_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeLoremSentences(3, 6, "en", 42);
            var r2 = _sut.FakeLoremSentences(3, 6, "en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        #region FakeProductNames Tests

        [Test]
        public void FakeProductNames_ReturnsRequestedCount()
        {
            var result = _sut.FakeProductNames(count: 5, locale: "en", seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.Not.Empty);
        }

        [Test]
        public void FakeProductNames_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeProductNames(3, "en", 42);
            var r2 = _sut.FakeProductNames(3, "en", 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        #endregion

        #region FakePastDates Tests

        [Test]
        public void FakePastDates_ReturnsRequestedCount()
        {
            var result = _sut.FakePastDates(count: 5, yearsToGoBack: 2, locale: "en", seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.LessThan(DateTime.UtcNow));
        }

        [Test]
        public void FakePastDates_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakePastDates(3, 1, "en", 42);
            var r2 = _sut.FakePastDates(3, 1, "en", 42);
            Assert.Multiple(() =>
            {
                for (int i = 0; i < r1.Count; i++)
                    Assert.That(r2[i].Date, Is.EqualTo(r1[i].Date));
            });
        }

        [Test]
        public void FakePastDates_YearsZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakePastDates(count: 5, yearsToGoBack: 0));
        }

        #endregion

        #region FakeNumbers Tests

        [Test]
        public void FakeNumbers_ReturnsRequestedCount()
        {
            var result = _sut.FakeNumbers(count: 5, min: 1, max: 100, seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.InRange(1, 100));
        }

        [Test]
        public void FakeNumbers_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeNumbers(3, 0, 100, 42);
            var r2 = _sut.FakeNumbers(3, 0, 100, 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        [Test]
        public void FakeNumbers_MinGreaterThanMax_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeNumbers(count: 5, min: 100, max: 10));
        }

        #endregion

        #region FakeGuids Tests

        [Test]
        public void FakeGuids_ReturnsRequestedCount()
        {
            var result = _sut.FakeGuids(count: 5, seed: 42);
            Assert.That(result, Has.Count.EqualTo(5));
            Assert.That(result, Has.All.Match(@"^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$"));
        }

        [Test]
        public void FakeGuids_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeGuids(3, 42);
            var r2 = _sut.FakeGuids(3, 42);
            Assert.That(r2, Is.EqualTo(r1));
        }

        [Test]
        public void FakeGuids_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeGuids(count: 0));
        }

        #endregion

        #region Bulk Validation Edge Cases

        [Test]
        public void FakeAmounts_DecimalsNegative_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeAmounts(count: 3, min: 0, max: 100, decimals: -1));
        }

        [Test]
        public void FakeAmounts_DecimalsExceedsMax_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeAmounts(count: 3, min: 0, max: 100, decimals: 11));
        }

        [Test]
        public void FakeLoremSentences_WordCountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSentences(count: 3, wordCount: 0));
        }

        [Test]
        public void FakeLoremSentences_WordCountExceedsMax_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSentences(count: 3, wordCount: 1_001));
        }

        [Test]
        public void FakeFullAddresses_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeFullAddresses(count: 0));
        }

        [Test]
        public void FakeCompanyNames_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeCompanyNames(count: 0));
        }

        [Test]
        public void FakeUrls_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeUrls(count: 0));
        }

        [Test]
        public void FakeLoremSentences_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeLoremSentences(count: 0));
        }

        [Test]
        public void FakeProductNames_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeProductNames(count: 0));
        }

        [Test]
        public void FakePastDates_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakePastDates(count: 0));
        }

        [Test]
        public void FakeNumbers_CountZero_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FakeNumbers(count: 0));
        }

        #endregion
    }
}
