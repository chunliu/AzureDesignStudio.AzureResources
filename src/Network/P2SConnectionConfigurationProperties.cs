// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for P2SConnectionConfiguration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class P2SConnectionConfigurationProperties
    {
        /// <summary>
        /// The reference to the address space resource which represents Address space for P2S VpnClient.
        /// </summary>
        [JsonPropertyName("vpnClientAddressPool")]
        public AddressSpace VpnClientAddressPool { get; set; }

        /// <summary>
        /// The Routing Configuration indicating the associated and propagated route tables on this connection.
        /// </summary>
        [JsonPropertyName("routingConfiguration")]
        public RoutingConfiguration RoutingConfiguration { get; set; }

        /// <summary>
        /// Flag indicating whether the enable internet security flag is turned on for the P2S Connections or not.
        /// </summary>
        [JsonPropertyName("enableInternetSecurity")]
        public bool EnableInternetSecurity { get; set; }
    }
}