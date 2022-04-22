using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// IP configuration for virtual network gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualNetworkGatewayIPConfiguration
    {
        /// <summary>
        /// Properties of the virtual network gateway ip configuration.
        /// </summary>
        [JsonPropertyName("properties")]
        public VirtualNetworkGatewayIPConfigurationPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}