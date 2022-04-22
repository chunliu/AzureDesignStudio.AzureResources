using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// BGP settings details.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BgpSettings
    {
        /// <summary>
        /// The BGP speaker's ASN.
        /// </summary>
        [JsonPropertyName("asn")]
        public int Asn { get; set; }

        /// <summary>
        /// The BGP peering address and BGP identifier of this BGP speaker.
        /// </summary>
        [JsonPropertyName("bgpPeeringAddress")]
        public string BgpPeeringAddress { get; set; }

        /// <summary>
        /// The weight added to routes learned from this BGP speaker.
        /// </summary>
        [JsonPropertyName("peerWeight")]
        public int PeerWeight { get; set; }

        /// <summary>
        /// BGP peering address with IP configuration ID for virtual network gateway.
        /// </summary>
        [JsonPropertyName("bgpPeeringAddresses")]
        public IList<IPConfigurationBgpPeeringAddress> BgpPeeringAddresses { get; set; }
    }
}