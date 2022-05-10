// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// An API Version Set contains the common configuration for a set of API Versions relating 
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiVersionSetContractDetails
    {
        /// <summary>
        /// Description of API Version Set.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Identifier for existing API Version Set. Omit this value to create a new Version Set.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The display Name of the API Version Set.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Name of HTTP header parameter that indicates the API Version if versioningScheme is set to `header`.
        /// </summary>
        [JsonPropertyName("versionHeaderName")]
        public string VersionHeaderName { get; set; }

        /// <summary>
        /// An value that determines where the API Version identifier will be located in a HTTP request.
        /// </summary>
        [JsonPropertyName("versioningScheme")]
        public string VersioningScheme { get; set; }

        /// <summary>
        /// Name of query parameter that indicates the API Version if versioningScheme is set to `query`.
        /// </summary>
        [JsonPropertyName("versionQueryName")]
        public string VersionQueryName { get; set; }
    }
}