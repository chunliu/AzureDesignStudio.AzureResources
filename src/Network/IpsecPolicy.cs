// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// An IPSec Policy configuration for a virtual network gateway connection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IpsecPolicy
    {
        /// <summary>
        /// The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site to site VPN tunnel.
        /// </summary>
        [Required]
        [JsonPropertyName("saLifeTimeSeconds")]
        public int SaLifeTimeSeconds { get; set; }

        /// <summary>
        /// The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site to site VPN tunnel.
        /// </summary>
        [Required]
        [JsonPropertyName("saDataSizeKilobytes")]
        public int SaDataSizeKilobytes { get; set; }

        /// <summary>
        /// The IPSec encryption algorithm (IKE phase 1).
        /// </summary>
        [Required]
        [JsonPropertyName("ipsecEncryption")]
        public string IpsecEncryption { get; set; }

        /// <summary>
        /// The IPSec integrity algorithm (IKE phase 1).
        /// </summary>
        [Required]
        [JsonPropertyName("ipsecIntegrity")]
        public string IpsecIntegrity { get; set; }

        /// <summary>
        /// The IKE encryption algorithm (IKE phase 2).
        /// </summary>
        [Required]
        [JsonPropertyName("ikeEncryption")]
        public string IkeEncryption { get; set; }

        /// <summary>
        /// The IKE integrity algorithm (IKE phase 2).
        /// </summary>
        [Required]
        [JsonPropertyName("ikeIntegrity")]
        public string IkeIntegrity { get; set; }

        /// <summary>
        /// The DH Group used in IKE Phase 1 for initial SA.
        /// </summary>
        [Required]
        [JsonPropertyName("dhGroup")]
        public string DhGroup { get; set; }

        /// <summary>
        /// The Pfs Group used in IKE Phase 2 for new child SA.
        /// </summary>
        [Required]
        [JsonPropertyName("pfsGroup")]
        public string PfsGroup { get; set; }
    }
}