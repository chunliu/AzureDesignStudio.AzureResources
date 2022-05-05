// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Defines a managed rule group override setting.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedRuleOverride
    {
        /// <summary>
        /// Identifier for the managed rule.
        /// </summary>
        [Required]
        [JsonPropertyName("ruleId")]
        public string RuleId { get; set; }

        /// <summary>
        /// The state of the managed rule. Defaults to Disabled if not specified.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}