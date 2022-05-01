using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the paths HTTP requests.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HttpSettingsRoutes
    {
        /// <summary>
        /// The prefix that should precede all the authentication/authorization paths.
        /// </summary>
        [JsonPropertyName("apiPrefix")]
        public string ApiPrefix { get; set; }
    }
}