// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the rule collection group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FirewallPolicyRuleCollectionGroupProperties
    {
        /// <summary>
        /// Priority of the Firewall Policy Rule Collection Group resource.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Group of Firewall Policy rule collections.
        /// </summary>
        [JsonPropertyName("ruleCollections")]
        public IList<FirewallPolicyRuleCollection> RuleCollections { get; set; }
    }
}