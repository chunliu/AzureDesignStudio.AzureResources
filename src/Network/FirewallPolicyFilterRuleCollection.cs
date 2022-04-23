using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Firewall Policy Filter Rule Collection.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicyFilterRuleCollection
    {
        /// <summary>
        /// The action type of a Filter rule collection.
        /// </summary>
        [JsonPropertyName("action")]
        public FirewallPolicyFilterRuleCollectionAction Action { get; set; }

        /// <summary>
        /// List of rules included in a rule collection.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<FirewallPolicyRule> Rules { get; set; }
        [Required]
        [JsonPropertyName("ruleCollectionType")]
        public string RuleCollectionType { get; set; }
    }
}