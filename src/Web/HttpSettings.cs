using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the HTTP requests for authentication and authorization requests made against App Service Authentication/Authorization.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HttpSettings
    {
        /// <summary>
        /// The configuration settings of a forward proxy used to make the requests.
        /// </summary>
        [JsonPropertyName("forwardProxy")]
        public ForwardProxy ForwardProxy { get; set; }

        /// <summary>
        /// <code>false</code> if the authentication/authorization responses not having the HTTPS scheme are permissible; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("requireHttps")]
        public bool RequireHttps { get; set; }

        /// <summary>
        /// The configuration settings of the paths HTTP requests.
        /// </summary>
        [JsonPropertyName("routes")]
        public HttpSettingsRoutes Routes { get; set; }
    }
}