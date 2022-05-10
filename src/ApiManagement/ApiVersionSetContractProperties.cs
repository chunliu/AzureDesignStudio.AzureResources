// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Properties of an API Version Set.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiVersionSetContractProperties
    {
        /// <summary>
        /// Description of API Version Set.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Name of API Version Set
        /// </summary>
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Name of HTTP header parameter that indicates the API Version if versioningScheme is set to `header`.
        /// </summary>
        [JsonPropertyName("versionHeaderName")]
        public string VersionHeaderName { get; set; }

        /// <summary>
        /// An value that determines where the API Version identifier will be located in a HTTP request.
        /// </summary>
        [Required]
        [JsonPropertyName("versioningScheme")]
        public string VersioningScheme { get; set; }

        /// <summary>
        /// Name of query parameter that indicates the API Version if versioningScheme is set to `query`.
        /// </summary>
        [JsonPropertyName("versionQueryName")]
        public string VersionQueryName { get; set; }
    }
}