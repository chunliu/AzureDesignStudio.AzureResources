// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Schema create or update contract Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GlobalSchemaContractProperties
    {
        /// <summary>
        /// Free-form schema entity description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Global Schema Document Properties.
        /// </summary>
        [JsonPropertyName("document")]
        public object Document { get; set; }

        /// <summary>
        /// Schema Type. Immutable.
        /// </summary>
        [Required]
        [JsonPropertyName("schemaType")]
        public string SchemaType { get; set; }

        /// <summary>
        /// Json-encoded string for non json-based schema.
        /// </summary>
        [JsonPropertyName("value")]
        public object Value { get; set; }
    }
}