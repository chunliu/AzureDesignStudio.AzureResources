using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Base
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ARMResourceBase
    {
        /// <summary>
        /// Name of the resource
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Resource type
        /// </summary>
        [Required]
        [JsonPropertyName("type")]
        public virtual string Type => throw new NotImplementedException();

        /// <summary>
        /// Condition of the resource
        /// </summary>
        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// API Version of the resource type, optional when apiProfile is used on the template
        /// </summary>
        [JsonPropertyName("apiVersion")]
        public virtual string ApiVersion => throw new NotImplementedException();

        /// <summary>
        /// Collection of resources this resource depends on
        /// </summary>
        [JsonPropertyName("dependsOn")]
        public IList<string> DependsOn { get; set; }
    }
}