// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VpnSite.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VpnSiteLinkProperties
    {
        /// <summary>
        /// The link provider properties.
        /// </summary>
        [JsonPropertyName("linkProperties")]
        public VpnLinkProviderProperties LinkProperties { get; set; }

        /// <summary>
        /// The ip-address for the vpn-site-link.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// FQDN of vpn-site-link.
        /// </summary>
        [JsonPropertyName("fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// The set of bgp properties.
        /// </summary>
        [JsonPropertyName("bgpProperties")]
        public VpnLinkBgpSettings BgpProperties { get; set; }
    }
}