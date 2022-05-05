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
    /// Defines a managed rule group override setting.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedRuleGroupOverride
    {
        /// <summary>
        /// The managed rule group to override.
        /// </summary>
        [Required]
        [JsonPropertyName("ruleGroupName")]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// List of rules that will be disabled. If none specified, all rules in the group will be disabled.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<ManagedRuleOverride> Rules { get; set; }
    }
}