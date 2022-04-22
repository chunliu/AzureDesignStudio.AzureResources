using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VirtualNetworkGatewayConnection properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualNetworkGatewayConnectionPropertiesFormat
    {
        /// <summary>
        /// The authorizationKey.
        /// </summary>
        [JsonPropertyName("authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// The reference to virtual network gateway resource.
        /// </summary>
        [Required]
        [JsonPropertyName("virtualNetworkGateway1")]
        public SubResource VirtualNetworkGateway1 { get; set; }

        /// <summary>
        /// The reference to virtual network gateway resource.
        /// </summary>
        [JsonPropertyName("virtualNetworkGateway2")]
        public SubResource VirtualNetworkGateway2 { get; set; }

        /// <summary>
        /// The reference to local network gateway resource.
        /// </summary>
        [JsonPropertyName("localNetworkGateway2")]
        public SubResource LocalNetworkGateway2 { get; set; }

        /// <summary>
        /// Gateway connection type.
        /// </summary>
        [Required]
        [JsonPropertyName("connectionType")]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Connection protocol used for this connection.
        /// </summary>
        [JsonPropertyName("connectionProtocol")]
        public string ConnectionProtocol { get; set; }

        /// <summary>
        /// The routing weight.
        /// </summary>
        [JsonPropertyName("routingWeight")]
        public int RoutingWeight { get; set; }

        /// <summary>
        /// The dead peer detection timeout of this connection in seconds.
        /// </summary>
        [JsonPropertyName("dpdTimeoutSeconds")]
        public int DpdTimeoutSeconds { get; set; }

        /// <summary>
        /// The connection mode for this connection.
        /// </summary>
        [JsonPropertyName("connectionMode")]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// The IPSec shared key.
        /// </summary>
        [JsonPropertyName("sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// The reference to peerings resource.
        /// </summary>
        [JsonPropertyName("peer")]
        public SubResource Peer { get; set; }

        /// <summary>
        /// EnableBgp flag.
        /// </summary>
        [JsonPropertyName("enableBgp")]
        public bool EnableBgp { get; set; }

        /// <summary>
        /// Use private local Azure IP for the connection.
        /// </summary>
        [JsonPropertyName("useLocalAzureIpAddress")]
        public bool UseLocalAzureIpAddress { get; set; }

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
        /// Bypass ExpressRoute Gateway for data forwarding.
        /// </summary>
        [JsonPropertyName("expressRouteGatewayBypass")]
        public bool ExpressRouteGatewayBypass { get; set; }
    }
}