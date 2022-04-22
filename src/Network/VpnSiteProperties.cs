using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VpnSite.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnSiteProperties
    {
        /// <summary>
        /// The VirtualWAN to which the vpnSite belongs.
        /// </summary>
        [JsonPropertyName("virtualWan")]
        public SubResource VirtualWan { get; set; }

        /// <summary>
        /// The device properties.
        /// </summary>
        [JsonPropertyName("deviceProperties")]
        public DeviceProperties DeviceProperties { get; set; }

        /// <summary>
        /// The ip-address for the vpn-site.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The key for vpn-site that can be used for connections.
        /// </summary>
        [JsonPropertyName("siteKey")]
        public string SiteKey { get; set; }

        /// <summary>
        /// The AddressSpace that contains an array of IP address ranges.
        /// </summary>
        [JsonPropertyName("addressSpace")]
        public AddressSpace AddressSpace { get; set; }

        /// <summary>
        /// The set of bgp properties.
        /// </summary>
        [JsonPropertyName("bgpProperties")]
        public BgpSettings BgpProperties { get; set; }

        /// <summary>
        /// IsSecuritySite flag.
        /// </summary>
        [JsonPropertyName("isSecuritySite")]
        public bool IsSecuritySite { get; set; }

        /// <summary>
        /// List of all vpn site links.
        /// </summary>
        [JsonPropertyName("vpnSiteLinks")]
        public IList<VpnSiteLink> VpnSiteLinks { get; set; }

        /// <summary>
        /// Office365 Policy.
        /// </summary>
        [JsonPropertyName("o365Policy")]
        public O365PolicyProperties O365Policy { get; set; }
    }
}