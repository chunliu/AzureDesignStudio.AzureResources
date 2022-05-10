// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// OAuth acquire token request body parameter (www-url-form-encoded).
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TokenBodyParameterContract
    {
        /// <summary>
        /// body parameter name.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// body parameter value.
        /// </summary>
        [Required]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}