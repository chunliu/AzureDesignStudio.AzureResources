using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Rewrite rule of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayRewriteRule
    {
        /// <summary>
        /// Name of the rewrite rule that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Rule Sequence of the rewrite rule that determines the order of execution of a particular rule in a RewriteRuleSet.
        /// </summary>
        [JsonPropertyName("ruleSequence")]
        public int RuleSequence { get; set; }

        /// <summary>
        /// Conditions based on which the action set execution will be evaluated.
        /// </summary>
        [JsonPropertyName("conditions")]
        public IList<ApplicationGatewayRewriteRuleCondition> Conditions { get; set; }

        /// <summary>
        /// Set of actions to be done as part of the rewrite Rule.
        /// </summary>
        [JsonPropertyName("actionSet")]
        public ApplicationGatewayRewriteRuleActionSet ActionSet { get; set; }
    }
}