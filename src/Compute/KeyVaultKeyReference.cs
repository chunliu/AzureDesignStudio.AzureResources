// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a reference to Key Vault Key
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class KeyVaultKeyReference
    {
        /// <summary>
        /// The URL referencing a key encryption key in Key Vault.
        /// </summary>
        [Required]
        [JsonPropertyName("keyUrl")]
        public string KeyUrl { get; set; }
        [Required]
        [JsonPropertyName("sourceVault")]
        public SubResource SourceVault { get; set; }
    }
}