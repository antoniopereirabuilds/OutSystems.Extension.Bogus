using NUnit.Framework;

namespace OutSystems.Bogus.Tests
{
    /// <summary>
    /// Tests for IFakeSystem actions: file name, MIME type, file extension, semver.
    /// </summary>
    [TestFixture]
    public class FakeSystemTests
    {
        private readonly FakeSystem _sut = new();

        [Test]
        public void FakeFileName_ReturnsNameWithExtension()
        {
            var result = _sut.FakeFileName();
            Assert.That(result, Does.Contain("."));
        }

        [Test]
        public void FakeMimeType_ReturnsSlashSeparated()
        {
            var result = _sut.FakeMimeType();
            Assert.That(result, Does.Contain("/"));
        }

        [Test]
        public void FakeFileExtension_ReturnsNonEmpty()
        {
            Assert.That(_sut.FakeFileExtension(), Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void FakeSemver_ReturnsDottedFormat()
        {
            var result = _sut.FakeSemver();
            var parts = result.Split('.');
            Assert.That(parts, Has.Length.EqualTo(3));
        }

        [Test]
        public void FakeFileName_WithSeed_IsDeterministic()
        {
            var r1 = _sut.FakeFileName(seed: 42);
            var r2 = _sut.FakeFileName(seed: 42);
            Assert.That(r2, Is.EqualTo(r1));
        }
    }
}
