// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for P2SVpnGateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class P2SVpnGatewayProperties
    {
        /// <summary>
        /// The VirtualHub to which the gateway belongs.
        /// </summary>
        [JsonPropertyName("virtualHub")]
        public SubResource VirtualHub { get; set; }

        /// <summary>
        /// List of all p2s connection configurations of the gateway.
        /// </summary>
        [JsonPropertyName("p2SConnectionConfigurations")]
        public IList<P2SConnectionConfiguration> P2SConnectionConfigurations { get; set; }

        /// <summary>
        /// The scale unit for this p2s vpn gateway.
        /// </summary>
        [JsonPropertyName("vpnGatewayScaleUnit")]
        public int VpnGatewayScaleUnit { get; set; }

        /// <summary>
        /// The VpnServerConfiguration to which the p2sVpnGateway is attached to.
        /// </summary>
        [JsonPropertyName("vpnServerConfiguration")]
        public SubResource VpnServerConfiguration { get; set; }

        /// <summary>
        /// List of all customer specified DNS servers IP addresses.
        /// </summary>
        [JsonPropertyName("customDnsServers")]
        public IList<string> CustomDnsServers { get; set; }

        /// <summary>
        /// Enable Routing Preference property for the Public IP Interface of the P2SVpnGateway.
        /// </summary>
        [JsonPropertyName("isRoutingPreferenceInternet")]
        public bool IsRoutingPreferenceInternet { get; set; }
    }
}