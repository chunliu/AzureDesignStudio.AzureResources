// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Api Schema Document Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SchemaDocumentProperties
    {
        /// <summary>
        /// Types definitions. Used for Swagger/OpenAPI v2/v3 schemas only, null otherwise.
        /// </summary>
        [JsonPropertyName("components")]
        public object Components { get; set; }

        /// <summary>
        /// Types definitions. Used for Swagger/OpenAPI v1 schemas only, null otherwise.
        /// </summary>
        [JsonPropertyName("definitions")]
        public object Definitions { get; set; }

        /// <summary>
        /// Json escaped string defining the document representing the Schema. Used for schemas other than Swagger/OpenAPI.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}