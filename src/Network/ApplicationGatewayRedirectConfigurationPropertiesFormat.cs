using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of redirect configuration of the application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayRedirectConfigurationPropertiesFormat
    {
        /// <summary>
        /// HTTP redirection type.
        /// </summary>
        [JsonPropertyName("redirectType")]
        public string RedirectType { get; set; }

        /// <summary>
        /// Reference to a listener to redirect the request to.
        /// </summary>
        [JsonPropertyName("targetListener")]
        public SubResource TargetListener { get; set; }

        /// <summary>
        /// Url to redirect the request to.
        /// </summary>
        [JsonPropertyName("targetUrl")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// Include path in the redirected url.
        /// </summary>
        [JsonPropertyName("includePath")]
        public bool IncludePath { get; set; }

        /// <summary>
        /// Include query string in the redirected url.
        /// </summary>
        [JsonPropertyName("includeQueryString")]
        public bool IncludeQueryString { get; set; }

        /// <summary>
        /// Request routing specifying redirect configuration.
        /// </summary>
        [JsonPropertyName("requestRoutingRules")]
        public IList<SubResource> RequestRoutingRules { get; set; }

        /// <summary>
        /// Url path maps specifying default redirect configuration.
        /// </summary>
        [JsonPropertyName("urlPathMaps")]
        public IList<SubResource> UrlPathMaps { get; set; }

        /// <summary>
        /// Path rules specifying redirect configuration.
        /// </summary>
        [JsonPropertyName("pathRules")]
        public IList<SubResource> PathRules { get; set; }
    }
}