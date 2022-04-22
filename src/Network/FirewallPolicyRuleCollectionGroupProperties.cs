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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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