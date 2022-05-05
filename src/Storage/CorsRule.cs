// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Specifies a CORS rule for the Blob service.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CorsRule
    {
        /// <summary>
        /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
        /// </summary>
        [Required]
        [JsonPropertyName("allowedHeaders")]
        public IList<string> AllowedHeaders { get; set; }

        /// <summary>
        /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
        /// </summary>
        [Required]
        [JsonPropertyName("allowedMethods")]
        public IList<string> AllowedMethods { get; set; }

        /// <summary>
        /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
        /// </summary>
        [Required]
        [JsonPropertyName("allowedOrigins")]
        public IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
        /// </summary>
        [Required]
        [JsonPropertyName("exposedHeaders")]
        public IList<string> ExposedHeaders { get; set; }

        /// <summary>
        /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
        /// </summary>
        [Required]
        [JsonPropertyName("maxAgeInSeconds")]
        public int MaxAgeInSeconds { get; set; }
    }
}