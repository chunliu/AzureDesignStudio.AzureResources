using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VirtualHub.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualHubProperties
    {
        /// <summary>
        /// The VirtualWAN to which the VirtualHub belongs.
        /// </summary>
        [JsonPropertyName("virtualWan")]
        public SubResource VirtualWan { get; set; }

        /// <summary>
        /// The VpnGateway associated with this VirtualHub.
        /// </summary>
        [JsonPropertyName("vpnGateway")]
        public SubResource VpnGateway { get; set; }

        /// <summary>
        /// The P2SVpnGateway associated with this VirtualHub.
        /// </summary>
        [JsonPropertyName("p2SVpnGateway")]
        public SubResource P2SVpnGateway { get; set; }

        /// <summary>
        /// The expressRouteGateway associated with this VirtualHub.
        /// </summary>
        [JsonPropertyName("expressRouteGateway")]
        public SubResource ExpressRouteGateway { get; set; }

        /// <summary>
        /// The azureFirewall associated with this VirtualHub.
        /// </summary>
        [JsonPropertyName("azureFirewall")]
        public SubResource AzureFirewall { get; set; }

        /// <summary>
        /// The securityPartnerProvider associated with this VirtualHub.
        /// </summary>
        [JsonPropertyName("securityPartnerProvider")]
        public SubResource SecurityPartnerProvider { get; set; }

        /// <summary>
        /// Address-prefix for this VirtualHub.
        /// </summary>
        [JsonPropertyName("addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// The routeTable associated with this virtual hub.
        /// </summary>
        [JsonPropertyName("routeTable")]
        public VirtualHubRouteTable RouteTable { get; set; }

        /// <summary>
        /// The Security Provider name.
        /// </summary>
        [JsonPropertyName("securityProviderName")]
        public string SecurityProviderName { get; set; }

        /// <summary>
        /// List of all virtual hub route table v2s associated with this VirtualHub.
        /// </summary>
        [JsonPropertyName("virtualHubRouteTableV2s")]
        public IList<VirtualHubRouteTableV2> VirtualHubRouteTableV2s { get; set; }

        /// <summary>
        /// The sku of this VirtualHub.
        /// </summary>
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// The routing state.
        /// </summary>
        [JsonPropertyName("routingState")]
        public string RoutingState { get; set; }

        /// <summary>
        /// VirtualRouter ASN.
        /// </summary>
        [JsonPropertyName("virtualRouterAsn")]
        public int VirtualRouterAsn { get; set; }

        /// <summary>
        /// VirtualRouter IPs.
        /// </summary>
        [JsonPropertyName("virtualRouterIps")]
        public IList<string> VirtualRouterIps { get; set; }

        /// <summary>
        /// Flag to control transit for VirtualRouter hub.
        /// </summary>
        [JsonPropertyName("allowBranchToBranchTraffic")]
        public bool AllowBranchToBranchTraffic { get; set; }
    }
}