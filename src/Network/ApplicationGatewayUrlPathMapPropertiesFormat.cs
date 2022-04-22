using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of UrlPathMap of the application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayUrlPathMapPropertiesFormat
    {
        /// <summary>
        /// Default backend address pool resource of URL path map.
        /// </summary>
        [JsonPropertyName("defaultBackendAddressPool")]
        public SubResource DefaultBackendAddressPool { get; set; }

        /// <summary>
        /// Default backend http settings resource of URL path map.
        /// </summary>
        [JsonPropertyName("defaultBackendHttpSettings")]
        public SubResource DefaultBackendHttpSettings { get; set; }

        /// <summary>
        /// Default Rewrite rule set resource of URL path map.
        /// </summary>
        [JsonPropertyName("defaultRewriteRuleSet")]
        public SubResource DefaultRewriteRuleSet { get; set; }

        /// <summary>
        /// Default redirect configuration resource of URL path map.
        /// </summary>
        [JsonPropertyName("defaultRedirectConfiguration")]
        public SubResource DefaultRedirectConfiguration { get; set; }

        /// <summary>
        /// Path rule of URL path map resource.
        /// </summary>
        [JsonPropertyName("pathRules")]
        public IList<ApplicationGatewayPathRule> PathRules { get; set; }
    }
}