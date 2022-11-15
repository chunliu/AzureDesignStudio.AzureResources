using AzureDesignStudio.AzureResources.Base;
using AzureDesignStudio.AzureResources.Network;
using Xunit;

namespace UnitTests
{
    public class AzureResourceHelperTests
    {
        [Fact]
        public void GetTypeOfAzureResourceTest()
        {
            var resType = AzureResourceHelper.GetTypeOfAzureResource("Microsoft.Network/virtualNetworks", "2022-05-01");
            Assert.NotNull(resType);
            Assert.True(resType == typeof(VirtualNetworks));

            resType = AzureResourceHelper.GetTypeOfAzureResource("Microsoft.Network/virtualNetwork", "2022-05-01");
            Assert.Null(resType);
        }

        [Fact]
        public void GetAzureResourceInstanceTest()
        {
            var vnet = AzureResourceHelper.GetAzureResourceInstance("Microsoft.Network/virtualNetworks", "2022-05-01");
            Assert.NotNull(vnet);
            Assert.True(vnet is VirtualNetworks);
        }
    }
}
