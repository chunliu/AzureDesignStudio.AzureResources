using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the rule group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualRouterPeeringProperties
    {
        /// <summary>
        /// Peer ASN.
        /// </summary>
        [JsonPropertyName("peerAsn")]
        public int PeerAsn { get; set; }

        /// <summary>
        /// Peer IP.
        /// </summary>
        [JsonPropertyName("peerIp")]
        public string PeerIp { get; set; }
    }
}