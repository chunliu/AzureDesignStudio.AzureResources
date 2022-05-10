// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Authorization header information.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BackendAuthorizationHeaderCredentials
    {
        /// <summary>
        /// Authentication Parameter value.
        /// </summary>
        [Required]
        [JsonPropertyName("parameter")]
        public string Parameter { get; set; }

        /// <summary>
        /// Authentication Scheme name.
        /// </summary>
        [Required]
        [JsonPropertyName("scheme")]
        public string Scheme { get; set; }
    }
}