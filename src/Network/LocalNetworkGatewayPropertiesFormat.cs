// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// LocalNetworkGateway properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LocalNetworkGatewayPropertiesFormat
    {
        /// <summary>
        /// Local network site address space.
        /// </summary>
        [JsonPropertyName("localNetworkAddressSpace")]
        public AddressSpace LocalNetworkAddressSpace { get; set; }

        /// <summary>
        /// IP address of local network gateway.
        /// </summary>
        [JsonPropertyName("gatewayIpAddress")]
        public string GatewayIpAddress { get; set; }

        /// <summary>
        /// FQDN of local network gateway.
        /// </summary>
        [JsonPropertyName("fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Local network gateway's BGP speaker settings.
        /// </summary>
        [JsonPropertyName("bgpSettings")]
        public BgpSettings BgpSettings { get; set; }
    }
}