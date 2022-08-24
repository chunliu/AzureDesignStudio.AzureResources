// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Object to set Table Access Policy.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TableSignedIdentifier
    {
        /// <summary>
        /// Table Access Policy Properties Object.
        /// </summary>
        [JsonPropertyName("accessPolicy")]
        public TableAccessPolicy AccessPolicy { get; set; }

        /// <summary>
        /// unique-64-character-value of the stored access policy.
        /// </summary>
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}