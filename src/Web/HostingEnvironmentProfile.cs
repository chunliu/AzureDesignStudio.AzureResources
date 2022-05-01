using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Specification for an App Service Environment to use for this resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HostingEnvironmentProfile
    {
        /// <summary>
        /// Resource ID of the App Service Environment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}