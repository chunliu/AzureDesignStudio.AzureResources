// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Rule of type nat.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NatRule
    {
        /// <summary>
        /// Array of FirewallPolicyRuleNetworkProtocols.
        /// </summary>
        [JsonPropertyName("ipProtocols")]
        public IList<string> IpProtocols { get; set; }

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
        /// List of destination ports.
        /// </summary>
        [JsonPropertyName("destinationPorts")]
        public IList<string> DestinationPorts { get; set; }

        /// <summary>
        /// The translated address for this NAT rule.
        /// </summary>
        [JsonPropertyName("translatedAddress")]
        public string TranslatedAddress { get; set; }

        /// <summary>
        /// The translated port for this NAT rule.
        /// </summary>
        [JsonPropertyName("translatedPort")]
        public string TranslatedPort { get; set; }

        /// <summary>
        /// List of source IpGroups for this rule.
        /// </summary>
        [JsonPropertyName("sourceIpGroups")]
        public IList<string> SourceIpGroups { get; set; }

        /// <summary>
        /// The translated FQDN for this NAT rule.
        /// </summary>
        [JsonPropertyName("translatedFqdn")]
        public string TranslatedFqdn { get; set; }
        [Required]
        [JsonPropertyName("ruleType")]
        public string RuleType { get; set; }
    }
}