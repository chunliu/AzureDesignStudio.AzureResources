// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayRewriteRuleSetPropertiesFormat
    {
        /// <summary>
        /// Rewrite rules in the rewrite rule set.
        /// </summary>
        [JsonPropertyName("rewriteRules")]
        public IList<ApplicationGatewayRewriteRule> RewriteRules { get; set; }
    }
}