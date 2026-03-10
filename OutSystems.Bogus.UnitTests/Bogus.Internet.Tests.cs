using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeInternet actions: URL, IP, IPv6, MAC, password, color, user agent.
    /// </summary>
    [TestFixture]
    public class FakeInternetTests
    {
        private readonly FakeInternet _sut = new();

        [Test]
        public void FakeUrl_ReturnsValidUrl()
        {
            var result = _sut.FakeUrl();
            Assert.That(result, Does.StartWith("http"));
        }

        [Test]
        public void FakeIp_ReturnsDottedFormat()
        {
            var result = _sut.FakeIp();
            var parts = result.Split('.');
            Assert.That(parts, Has.Length.EqualTo(4));
        }

        [Test]
        public void FakeIpv6_ReturnsColonSeparated()
        {
            var result = _sut.FakeIpv6();
            Assert.That(result, Does.Contain(":"));
        }

        [Test]
        public void FakeMacAddress_ReturnsSixGroups()
        {
            var result = _sut.FakeMacAddress();
            var parts = result.Split(':');
            Assert.That(parts, Has.Length.EqualTo(6));
        }

        [Test]
        public void FakePassword_DefaultLength_ReturnsNonEmpty()
        {
            var result = _sut.FakePassword();
            Assert.That(result, Has.Length.GreaterThanOrEqualTo(10));
        }

        [Test]
        public void FakePassword_CustomLength_ReturnsCorrectLength()
        {
            var result = _sut.FakePassword(20, seed: 42);
            Assert.That(result, Has.Length.GreaterThanOrEqualTo(20));
        }

        [Test]
        public void FakeColor_ReturnsHexFormat()
        {
            var result = _sut.FakeColor();
            Assert.That(result, Does.StartWith("#"));
        }

        [Test]
        public void FakeUserAgent_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeUserAgent(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeUrl_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeUrl(seed: 42);
            var r2 = _sut.FakeUrl(seed: 42);
            Assert.That(r2, Is.EqualTo(r1));
        }
    }
}
