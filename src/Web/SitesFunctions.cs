using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Microsoft.Web/sites/functions
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SitesFunctions : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01";

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// FunctionEnvelope resource specific properties
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public FunctionEnvelopeProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<SitesFunctionsKeys> Resources { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Web/sites/functions";
    }
}