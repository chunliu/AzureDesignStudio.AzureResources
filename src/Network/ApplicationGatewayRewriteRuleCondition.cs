using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Set of conditions in the Rewrite Rule in Application Gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayRewriteRuleCondition
    {
        /// <summary>
        /// The condition parameter of the RewriteRuleCondition.
        /// </summary>
        [JsonPropertyName("variable")]
        public string Variable { get; set; }

        /// <summary>
        /// The pattern, either fixed string or regular expression, that evaluates the truthfulness of the condition.
        /// </summary>
        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// Setting this parameter to truth value with force the pattern to do a case in-sensitive comparison.
        /// </summary>
        [JsonPropertyName("ignoreCase")]
        public bool IgnoreCase { get; set; }

        /// <summary>
        /// Setting this value as truth will force to check the negation of the condition given by the user.
        /// </summary>
        [JsonPropertyName("negate")]
        public bool Negate { get; set; }
    }
}