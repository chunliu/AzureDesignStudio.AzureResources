using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of Virtual Network Tap configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NetworkInterfaceTapConfigurationPropertiesFormat
    {
        /// <summary>
        /// The reference to the Virtual Network Tap resource.
        /// </summary>
        [JsonPropertyName("virtualNetworkTap")]
        public SubResource VirtualNetworkTap { get; set; }
    }
}