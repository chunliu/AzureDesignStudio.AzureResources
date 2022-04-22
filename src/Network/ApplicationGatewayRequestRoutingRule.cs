using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Request routing rule of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayRequestRoutingRule
    {
        /// <summary>
        /// Properties of the application gateway request routing rule.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayRequestRoutingRulePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the request routing rule that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}