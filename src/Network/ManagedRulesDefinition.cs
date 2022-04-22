using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Allow to exclude some variable satisfy the condition for the WAF check.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedRulesDefinition
    {
        /// <summary>
        /// The Exclusions that are applied on the policy.
        /// </summary>
        [JsonPropertyName("exclusions")]
        public IList<OwaspCrsExclusionEntry> Exclusions { get; set; }

        /// <summary>
        /// The managed rule sets that are associated with the policy.
        /// </summary>
        [Required]
        [JsonPropertyName("managedRuleSets")]
        public IList<ManagedRuleSet> ManagedRuleSets { get; set; }
    }
}