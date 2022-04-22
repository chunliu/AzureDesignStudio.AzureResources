using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of rewrite rule set of the application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayRewriteRuleSetPropertiesFormat
    {
        /// <summary>
        /// Rewrite rules in the rewrite rule set.
        /// </summary>
        [JsonPropertyName("rewriteRules")]
        public IList<ApplicationGatewayRewriteRule> RewriteRules { get; set; }
    }
}