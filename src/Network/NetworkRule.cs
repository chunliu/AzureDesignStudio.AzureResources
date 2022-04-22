using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Rule of type network.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NetworkRule
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
        /// List of source IpGroups for this rule.
        /// </summary>
        [JsonPropertyName("sourceIpGroups")]
        public IList<string> SourceIpGroups { get; set; }

        /// <summary>
        /// List of destination IpGroups for this rule.
        /// </summary>
        [JsonPropertyName("destinationIpGroups")]
        public IList<string> DestinationIpGroups { get; set; }

        /// <summary>
        /// List of destination FQDNs.
        /// </summary>
        [JsonPropertyName("destinationFqdns")]
        public IList<string> DestinationFqdns { get; set; }
        [Required]
        [JsonPropertyName("ruleType")]
        public string RuleType { get; set; }
    }
}