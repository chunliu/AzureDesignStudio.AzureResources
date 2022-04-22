using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VpnGateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnGatewayProperties
    {
        /// <summary>
        /// The VirtualHub to which the gateway belongs.
        /// </summary>
        [JsonPropertyName("virtualHub")]
        public SubResource VirtualHub { get; set; }

        /// <summary>
        /// List of all vpn connections to the gateway.
        /// </summary>
        [JsonPropertyName("connections")]
        public IList<VpnConnection> Connections { get; set; }

        /// <summary>
        /// Local network gateway's BGP speaker settings.
        /// </summary>
        [JsonPropertyName("bgpSettings")]
        public BgpSettings BgpSettings { get; set; }

        /// <summary>
        /// The scale unit for this vpn gateway.
        /// </summary>
        [JsonPropertyName("vpnGatewayScaleUnit")]
        public int VpnGatewayScaleUnit { get; set; }

        /// <summary>
        /// Enable Routing Preference property for the Public IP Interface of the VpnGateway.
        /// </summary>
        [JsonPropertyName("isRoutingPreferenceInternet")]
        public bool IsRoutingPreferenceInternet { get; set; }

        /// <summary>
        /// List of all the nat Rules associated with the gateway.
        /// </summary>
        [JsonPropertyName("natRules")]
        public IList<VpnGatewayNatRule> NatRules { get; set; }
    }
}