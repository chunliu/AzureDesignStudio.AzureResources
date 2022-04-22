using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the express route circuit connection.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteCircuitConnectionPropertiesFormat
    {
        /// <summary>
        /// Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection.
        /// </summary>
        [JsonPropertyName("expressRouteCircuitPeering")]
        public SubResource ExpressRouteCircuitPeering { get; set; }

        /// <summary>
        /// Reference to Express Route Circuit Private Peering Resource of the peered circuit.
        /// </summary>
        [JsonPropertyName("peerExpressRouteCircuitPeering")]
        public SubResource PeerExpressRouteCircuitPeering { get; set; }

        /// <summary>
        /// /29 IP address space to carve out Customer addresses for tunnels.
        /// </summary>
        [JsonPropertyName("addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// The authorization key.
        /// </summary>
        [JsonPropertyName("authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// IPv6 Address PrefixProperties of the express route circuit connection.
        /// </summary>
        [JsonPropertyName("ipv6CircuitConnectionConfig")]
        public Ipv6CircuitConnectionConfig Ipv6CircuitConnectionConfig { get; set; }
    }
}