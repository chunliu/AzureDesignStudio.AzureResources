// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// BGP settings details for a link.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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