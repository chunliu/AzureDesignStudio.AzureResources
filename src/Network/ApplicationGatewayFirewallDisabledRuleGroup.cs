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
    /// Allows to disable rules within a rule group or an entire rule group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayFirewallDisabledRuleGroup
    {
        /// <summary>
        /// The name of the rule group that will be disabled.
        /// </summary>
        [Required]
        [JsonPropertyName("ruleGroupName")]
        public string RuleGroupName { get; set; }

        /// <summary>
        /// The list of rules that will be disabled. If null, all rules of the rule group will be disabled.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<int> Rules { get; set; }
    }
}