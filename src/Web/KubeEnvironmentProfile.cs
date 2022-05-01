using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Specification for a Kubernetes Environment to use for this resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class KubeEnvironmentProfile
    {
        /// <summary>
        /// Resource ID of the Kubernetes Environment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}