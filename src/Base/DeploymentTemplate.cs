using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Base
{
    /// <summary>
    /// An Azure deployment template
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class DeploymentTemplate
    {
        /// <summary>
        /// JSON schema reference
        /// </summary>
        [Required]
        [JsonPropertyName("$schema")]
        public string Schema { get; set; }

        /// <summary>
        /// Additional unstructured metadata to include with the template deployment.
        /// </summary>
        [JsonPropertyName("metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// The apiProfile to use for all resources in the template.
        /// </summary>
        [JsonPropertyName("apiProfile")]
        public string ApiProfile { get; set; }

        /// <summary>
        /// A 4 number format for the version number of this template file. For example, 1.0.0.0
        /// </summary>
        [Required]
        [JsonPropertyName("contentVersion")]
        public string ContentVersion { get; set; }

        /// <summary>
        /// Variable definitions
        /// </summary>
        [JsonPropertyName("variables")]
        public object Variables { get; set; }

        /// <summary>
        /// Input parameter definitions
        /// </summary>
        [JsonPropertyName("parameters")]
        public IDictionary<string, Parameter> Parameters { get; set; }

        /// <summary>
        /// User defined functions
        /// </summary>
        [JsonPropertyName("functions")]
        public IList<FunctionNamespace> Functions { get; set; }

        /// <summary>
        /// Collection of resources to be deployed
        /// </summary>
        [Required]
        [JsonPropertyName("resources")]
        public IList<ResourceBase> Resources { get; set; }

        /// <summary>
        /// Output parameter definitions
        /// </summary>
        [JsonPropertyName("outputs")]
        public IDictionary<string, Output> Outputs { get; set; }
    }
}