using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Defines contents of a web application rule.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class WebApplicationFirewallCustomRule
    {
        /// <summary>
        /// The name of the resource that is unique within a policy. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.
        /// </summary>
        [Required]
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// The rule type.
        /// </summary>
        [Required]
        [JsonPropertyName("ruleType")]
        public string RuleType { get; set; }

        /// <summary>
        /// List of match conditions.
        /// </summary>
        [Required]
        [JsonPropertyName("matchConditions")]
        public IList<MatchCondition> MatchConditions { get; set; }

        /// <summary>
        /// Type of Actions.
        /// </summary>
        [Required]
        [JsonPropertyName("action")]
        public string Action { get; set; }
    }
}