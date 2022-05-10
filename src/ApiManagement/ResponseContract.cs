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
    /// Operation response details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ResponseContract
    {
        /// <summary>
        /// Operation response description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Collection of operation response headers.
        /// </summary>
        [JsonPropertyName("headers")]
        public IList<ParameterContract> Headers { get; set; }

        /// <summary>
        /// Collection of operation response representations.
        /// </summary>
        [JsonPropertyName("representations")]
        public IList<RepresentationContract> Representations { get; set; }

        /// <summary>
        /// Operation response HTTP status code.
        /// </summary>
        [Required]
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
    }
}