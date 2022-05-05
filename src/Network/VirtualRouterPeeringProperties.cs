// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the rule group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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