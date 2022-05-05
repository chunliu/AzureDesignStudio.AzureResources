// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Network rule set
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkRuleSet
    {
        /// <summary>
        /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
        /// </summary>
        [JsonPropertyName("bypass")]
        public string Bypass { get; set; }

        /// <summary>
        /// Specifies the default action of allow or deny when no other rules match.
        /// </summary>
        [Required]
        [JsonPropertyName("defaultAction")]
        public string DefaultAction { get; set; }

        /// <summary>
        /// Sets the IP ACL rules
        /// </summary>
        [JsonPropertyName("ipRules")]
        public IList<IPRule> IpRules { get; set; }

        /// <summary>
        /// Sets the resource access rules
        /// </summary>
        [JsonPropertyName("resourceAccessRules")]
        public IList<ResourceAccessRule> ResourceAccessRules { get; set; }

        /// <summary>
        /// Sets the virtual network rules
        /// </summary>
        [JsonPropertyName("virtualNetworkRules")]
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; set; }
    }
}