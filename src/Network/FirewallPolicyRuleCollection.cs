using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the rule collection.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicyRuleCollection
    {
        /// <summary>
        /// The name of the rule collection.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Priority of the Firewall Policy Rule Collection resource.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }
        [Required]
        [JsonPropertyName("ruleCollectionType")]
        public string RuleCollectionType { get; set; }
    }
}