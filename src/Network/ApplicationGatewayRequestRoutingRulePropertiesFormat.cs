using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of request routing rule of the application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayRequestRoutingRulePropertiesFormat
    {
        /// <summary>
        /// Rule type.
        /// </summary>
        [JsonPropertyName("ruleType")]
        public string RuleType { get; set; }

        /// <summary>
        /// Priority of the request routing rule.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Backend address pool resource of the application gateway.
        /// </summary>
        [JsonPropertyName("backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Backend http settings resource of the application gateway.
        /// </summary>
        [JsonPropertyName("backendHttpSettings")]
        public SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Http listener resource of the application gateway.
        /// </summary>
        [JsonPropertyName("httpListener")]
        public SubResource HttpListener { get; set; }

        /// <summary>
        /// URL path map resource of the application gateway.
        /// </summary>
        [JsonPropertyName("urlPathMap")]
        public SubResource UrlPathMap { get; set; }

        /// <summary>
        /// Rewrite Rule Set resource in Basic rule of the application gateway.
        /// </summary>
        [JsonPropertyName("rewriteRuleSet")]
        public SubResource RewriteRuleSet { get; set; }

        /// <summary>
        /// Redirect configuration resource of the application gateway.
        /// </summary>
        [JsonPropertyName("redirectConfiguration")]
        public SubResource RedirectConfiguration { get; set; }
    }
}