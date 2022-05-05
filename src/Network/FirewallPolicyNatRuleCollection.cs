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
    /// Firewall Policy NAT Rule Collection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FirewallPolicyNatRuleCollection
    {
        /// <summary>
        /// The action type of a Nat rule collection.
        /// </summary>
        [JsonPropertyName("action")]
        public FirewallPolicyNatRuleCollectionAction Action { get; set; }

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