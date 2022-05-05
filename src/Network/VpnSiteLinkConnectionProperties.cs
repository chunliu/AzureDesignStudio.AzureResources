// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VpnConnection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VpnSiteLinkConnectionProperties
    {
        /// <summary>
        /// Id of the connected vpn site link.
        /// </summary>
        [JsonPropertyName("vpnSiteLink")]
        public SubResource VpnSiteLink { get; set; }

        /// <summary>
        /// Routing weight for vpn connection.
        /// </summary>
        [JsonPropertyName("routingWeight")]
        public int RoutingWeight { get; set; }

        /// <summary>
        /// Vpn link connection mode.
        /// </summary>
        [JsonPropertyName("vpnLinkConnectionMode")]
        public string VpnLinkConnectionMode { get; set; }

        /// <summary>
        /// The connection status.
        /// </summary>
        [JsonPropertyName("connectionStatus")]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// Connection protocol used for this connection.
        /// </summary>
        [JsonPropertyName("vpnConnectionProtocolType")]
        public string VpnConnectionProtocolType { get; set; }

        /// <summary>
        /// Expected bandwidth in MBPS.
        /// </summary>
        [JsonPropertyName("connectionBandwidth")]
        public int ConnectionBandwidth { get; set; }

        /// <summary>
        /// SharedKey for the vpn connection.
        /// </summary>
        [JsonPropertyName("sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// EnableBgp flag.
        /// </summary>
        [JsonPropertyName("enableBgp")]
        public bool EnableBgp { get; set; }

        /// <summary>
        /// Enable policy-based traffic selectors.
        /// </summary>
        [JsonPropertyName("usePolicyBasedTrafficSelectors")]
        public bool UsePolicyBasedTrafficSelectors { get; set; }

        /// <summary>
        /// The IPSec Policies to be considered by this connection.
        /// </summary>
        [JsonPropertyName("ipsecPolicies")]
        public IList<IpsecPolicy> IpsecPolicies { get; set; }

        /// <summary>
        /// EnableBgp flag.
        /// </summary>
        [JsonPropertyName("enableRateLimiting")]
        public bool EnableRateLimiting { get; set; }

        /// <summary>
        /// Use local azure ip to initiate connection.
        /// </summary>
        [JsonPropertyName("useLocalAzureIpAddress")]
        public bool UseLocalAzureIpAddress { get; set; }

        /// <summary>
        /// List of ingress NatRules.
        /// </summary>
        [JsonPropertyName("ingressNatRules")]
        public IList<SubResource> IngressNatRules { get; set; }

        /// <summary>
        /// List of egress NatRules.
        /// </summary>
        [JsonPropertyName("egressNatRules")]
        public IList<SubResource> EgressNatRules { get; set; }
    }
}