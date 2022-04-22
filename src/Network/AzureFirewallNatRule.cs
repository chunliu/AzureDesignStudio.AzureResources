using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of a NAT rule.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureFirewallNatRule
    {
        /// <summary>
        /// Name of the NAT rule.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the rule.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// List of source IP addresses for this rule.
        /// </summary>
        [JsonPropertyName("sourceAddresses")]
        public IList<string> SourceAddresses { get; set; }

        /// <summary>
        /// List of destination IP addresses for this rule. Supports IP ranges, prefixes, and service tags.
        /// </summary>
        [JsonPropertyName("destinationAddresses")]
        public IList<string> DestinationAddresses { get; set; }

        /// <summary>
        /// List of destination ports.
        /// </summary>
        [JsonPropertyName("destinationPorts")]
        public IList<string> DestinationPorts { get; set; }

        /// <summary>
        /// Array of AzureFirewallNetworkRuleProtocols applicable to this NAT rule.
        /// </summary>
        [JsonPropertyName("protocols")]
        public IList<string> Protocols { get; set; }

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
        /// The translated FQDN for this NAT rule.
        /// </summary>
        [JsonPropertyName("translatedFqdn")]
        public string TranslatedFqdn { get; set; }

        /// <summary>
        /// List of source IpGroups for this rule.
        /// </summary>
        [JsonPropertyName("sourceIpGroups")]
        public IList<string> SourceIpGroups { get; set; }
    }
}