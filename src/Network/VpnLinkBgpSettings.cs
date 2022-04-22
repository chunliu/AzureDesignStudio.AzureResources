using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// BGP settings details for a link.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnLinkBgpSettings
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
    }
}