using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Rewrite rule set of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayRewriteRuleSet
    {
        /// <summary>
        /// Properties of the application gateway rewrite rule set.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayRewriteRuleSetPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the rewrite rule set that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}