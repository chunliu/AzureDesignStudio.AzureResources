using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Defines a managed rule set.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedRuleSet
    {
        /// <summary>
        /// Defines the rule set type to use.
        /// </summary>
        [Required]
        [JsonPropertyName("ruleSetType")]
        public string RuleSetType { get; set; }

        /// <summary>
        /// Defines the version of the rule set to use.
        /// </summary>
        [Required]
        [JsonPropertyName("ruleSetVersion")]
        public string RuleSetVersion { get; set; }

        /// <summary>
        /// Defines the rule group overrides to apply to the rule set.
        /// </summary>
        [JsonPropertyName("ruleGroupOverrides")]
        public IList<ManagedRuleGroupOverride> RuleGroupOverrides { get; set; }
    }
}