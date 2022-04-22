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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnConnectionProperties
    {
        /// <summary>
        /// Id of the connected vpn site.
        /// </summary>
        [JsonPropertyName("remoteVpnSite")]
        public SubResource RemoteVpnSite { get; set; }

        /// <summary>
        /// Routing weight for vpn connection.
        /// </summary>
        [JsonPropertyName("routingWeight")]
        public int RoutingWeight { get; set; }

        /// <summary>
        /// DPD timeout in seconds for vpn connection.
        /// </summary>
        [JsonPropertyName("dpdTimeoutSeconds")]
        public int DpdTimeoutSeconds { get; set; }

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
        /// The Traffic Selector Policies to be considered by this connection.
        /// </summary>
        [JsonPropertyName("trafficSelectorPolicies")]
        public IList<TrafficSelectorPolicy> TrafficSelectorPolicies { get; set; }

        /// <summary>
        /// EnableBgp flag.
        /// </summary>
        [JsonPropertyName("enableRateLimiting")]
        public bool EnableRateLimiting { get; set; }

        /// <summary>
        /// Enable internet security.
        /// </summary>
        [JsonPropertyName("enableInternetSecurity")]
        public bool EnableInternetSecurity { get; set; }

        /// <summary>
        /// Use local azure ip to initiate connection.
        /// </summary>
        [JsonPropertyName("useLocalAzureIpAddress")]
        public bool UseLocalAzureIpAddress { get; set; }

        /// <summary>
        /// List of all vpn site link connections to the gateway.
        /// </summary>
        [JsonPropertyName("vpnLinkConnections")]
        public IList<VpnSiteLinkConnection> VpnLinkConnections { get; set; }

        /// <summary>
        /// The Routing Configuration indicating the associated and propagated route tables on this connection.
        /// </summary>
        [JsonPropertyName("routingConfiguration")]
        public RoutingConfiguration RoutingConfiguration { get; set; }
    }
}