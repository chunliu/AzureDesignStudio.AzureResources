// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Description of an App Service Environment.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AppServiceEnvironment
    {
        /// <summary>
        /// Custom settings for changing the behavior of the App Service Environment.
        /// </summary>
        [JsonPropertyName("clusterSettings")]
        public IList<NameValuePair> ClusterSettings { get; set; }

        /// <summary>
        /// Full view of the custom domain suffix configuration for ASEv3.
        /// </summary>
        [JsonPropertyName("customDnsSuffixConfiguration")]
        public CustomDnsSuffixConfiguration CustomDnsSuffixConfiguration { get; set; }

        /// <summary>
        /// Dedicated Host Count
        /// </summary>
        [JsonPropertyName("dedicatedHostCount")]
        public int DedicatedHostCount { get; set; }

        /// <summary>
        /// DNS suffix of the App Service Environment.
        /// </summary>
        [JsonPropertyName("dnsSuffix")]
        public string DnsSuffix { get; set; }

        /// <summary>
        /// Scale factor for front-ends.
        /// </summary>
        [JsonPropertyName("frontEndScaleFactor")]
        public int FrontEndScaleFactor { get; set; }

        /// <summary>
        /// Specifies which endpoints to serve internally in the Virtual Network for the App Service Environment.
        /// </summary>
        [JsonPropertyName("internalLoadBalancingMode")]
        public string InternalLoadBalancingMode { get; set; }

        /// <summary>
        /// Number of IP SSL addresses reserved for the App Service Environment.
        /// </summary>
        [JsonPropertyName("ipsslAddressCount")]
        public int IpsslAddressCount { get; set; }

        /// <summary>
        /// Front-end VM size, e.g. "Medium", "Large".
        /// </summary>
        [JsonPropertyName("multiSize")]
        public string MultiSize { get; set; }

        /// <summary>
        /// Full view of networking configuration for an ASE.
        /// </summary>
        [JsonPropertyName("networkingConfiguration")]
        public AseV3NetworkingConfiguration NetworkingConfiguration { get; set; }

        /// <summary>
        /// Upgrade Preference.
        /// </summary>
        [JsonPropertyName("upgradePreference")]
        public string UpgradePreference { get; set; }

        /// <summary>
        /// User added ip ranges to whitelist on ASE db
        /// </summary>
        [JsonPropertyName("userWhitelistedIpRanges")]
        public IList<string> UserWhitelistedIpRanges { get; set; }

        /// <summary>
        /// Specification for using a Virtual Network.
        /// </summary>
        [Required]
        [JsonPropertyName("virtualNetwork")]
        public VirtualNetworkProfile VirtualNetwork { get; set; }

        /// <summary>
        /// Whether or not this App Service Environment is zone-redundant.
        /// </summary>
        [JsonPropertyName("zoneRedundant")]
        public bool ZoneRedundant { get; set; }
    }
}