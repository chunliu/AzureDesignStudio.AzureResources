using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Microsoft.Web/kubeEnvironments
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class KubeEnvironments : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01";

        /// <summary>
        /// Extended Location.
        /// </summary>
        [JsonPropertyName("extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// KubeEnvironment resource specific properties
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public KubeEnvironmentProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Web/kubeEnvironments";
    }
}