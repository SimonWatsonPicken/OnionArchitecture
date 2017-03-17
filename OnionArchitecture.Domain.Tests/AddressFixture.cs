using NUnit.Framework;

namespace OnionArchitecture.Domain.Tests
{
    [TestFixture]
    public class AddressFixture
    {
        [Test]
        public void GetRegion()
        {
            // Arrange.
            var ukAddress = new Address();

            // Act.
            var regionCode = ukAddress.RegionName;

            // Assert.
            Assert.AreEqual("GB", regionCode);
        }
    }
}