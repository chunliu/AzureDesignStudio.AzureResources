using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Information about the formal API definition for the app.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApiDefinitionInfo
    {
        /// <summary>
        /// The URL of the API definition.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}