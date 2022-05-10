// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Operation parameters details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ParameterContract
    {
        /// <summary>
        /// Default parameter value.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Parameter description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Parameter examples.
        /// </summary>
        [JsonPropertyName("examples")]
        public IDictionary<string, object> Examples { get; set; }

        /// <summary>
        /// Parameter name.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether parameter is required or not.
        /// </summary>
        [JsonPropertyName("required")]
        public bool Required { get; set; }

        /// <summary>
        /// Schema identifier.
        /// </summary>
        [JsonPropertyName("schemaId")]
        public string SchemaId { get; set; }

        /// <summary>
        /// Parameter type.
        /// </summary>
        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Type name defined by the schema.
        /// </summary>
        [JsonPropertyName("typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Parameter values.
        /// </summary>
        [JsonPropertyName("values")]
        public IList<string> Values { get; set; }
    }
}