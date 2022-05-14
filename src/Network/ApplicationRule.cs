// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Rule of type application.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationRule : FirewallPolicyRule
    {
        /// <summary>
        /// List of source IP addresses for this rule.
        /// </summary>
        [JsonPropertyName("sourceAddresses")]
        public IList<string> SourceAddresses { get; set; }

        /// <summary>
        /// List of destination IP addresses or Service Tags.
        /// </summary>
        [JsonPropertyName("destinationAddresses")]
        public IList<string> DestinationAddresses { get; set; }

        /// <summary>
        /// Array of Application Protocols.
        /// </summary>
        [JsonPropertyName("protocols")]
        public IList<FirewallPolicyRuleApplicationProtocol> Protocols { get; set; }

        /// <summary>
        /// List of FQDNs for this rule.
        /// </summary>
        [JsonPropertyName("targetFqdns")]
        public IList<string> TargetFqdns { get; set; }

        /// <summary>
        /// List of Urls for this rule condition.
        /// </summary>
        [JsonPropertyName("targetUrls")]
        public IList<string> TargetUrls { get; set; }

        /// <summary>
        /// List of FQDN Tags for this rule.
        /// </summary>
        [JsonPropertyName("fqdnTags")]
        public IList<string> FqdnTags { get; set; }

        /// <summary>
        /// List of source IpGroups for this rule.
        /// </summary>
        [JsonPropertyName("sourceIpGroups")]
        public IList<string> SourceIpGroups { get; set; }

        /// <summary>
        /// Terminate TLS connections for this rule.
        /// </summary>
        [JsonPropertyName("terminateTLS")]
        public bool TerminateTLS { get; set; }

        /// <summary>
        /// List of destination azure web categories.
        /// </summary>
        [JsonPropertyName("webCategories")]
        public IList<string> WebCategories { get; set; }
    }
}