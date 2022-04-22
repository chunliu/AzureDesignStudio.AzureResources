using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of express route cross connection peering.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteCrossConnectionPeeringProperties
    {
        /// <summary>
        /// The peering type.
        /// </summary>
        [JsonPropertyName("peeringType")]
        public string PeeringType { get; set; }

        /// <summary>
        /// The peering state.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The peer ASN.
        /// </summary>
        [JsonPropertyName("peerASN")]
        public int PeerASN { get; set; }

        /// <summary>
        /// The primary address prefix.
        /// </summary>
        [JsonPropertyName("primaryPeerAddressPrefix")]
        public string PrimaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// The secondary address prefix.
        /// </summary>
        [JsonPropertyName("secondaryPeerAddressPrefix")]
        public string SecondaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// The shared key.
        /// </summary>
        [JsonPropertyName("sharedKey")]
        public string SharedKey { get; set; }

        /// <summary>
        /// The VLAN ID.
        /// </summary>
        [JsonPropertyName("vlanId")]
        public int VlanId { get; set; }

        /// <summary>
        /// The Microsoft peering configuration.
        /// </summary>
        [JsonPropertyName("microsoftPeeringConfig")]
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }

        /// <summary>
        /// The GatewayManager Etag.
        /// </summary>
        [JsonPropertyName("gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }

        /// <summary>
        /// The IPv6 peering configuration.
        /// </summary>
        [JsonPropertyName("ipv6PeeringConfig")]
        public Ipv6ExpressRouteCircuitPeeringConfig Ipv6PeeringConfig { get; set; }
    }
}