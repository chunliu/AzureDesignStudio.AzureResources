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
    /// Operation request/response representation details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RepresentationContract
    {
        /// <summary>
        /// Specifies a registered or custom content type for this representation, e.g. application/xml.
        /// </summary>
        [Required]
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Parameter examples.
        /// </summary>
        [JsonPropertyName("examples")]
        public IDictionary<string, object> Examples { get; set; }

        /// <summary>
        /// Collection of form parameters. Required if 'contentType' value is either 'application/x-www-form-urlencoded' or 'multipart/form-data'..
        /// </summary>
        [JsonPropertyName("formParameters")]
        public IList<ParameterContract> FormParameters { get; set; }

        /// <summary>
        /// Schema identifier. Applicable only if 'contentType' value is neither 'application/x-www-form-urlencoded' nor 'multipart/form-data'.
        /// </summary>
        [JsonPropertyName("schemaId")]
        public string SchemaId { get; set; }

        /// <summary>
        /// Type name defined by the schema. Applicable only if 'contentType' value is neither 'application/x-www-form-urlencoded' nor 'multipart/form-data'.
        /// </summary>
        [JsonPropertyName("typeName")]
        public string TypeName { get; set; }
    }
}