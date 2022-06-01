// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a reference to Key Vault Secret
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class KeyVaultSecretReference
    {
        /// <summary>
        /// The URL referencing a secret in a Key Vault.
        /// </summary>
        [Required]
        [JsonPropertyName("secretUrl")]
        public string SecretUrl { get; set; }
        [Required]
        [JsonPropertyName("sourceVault")]
        public SubResource SourceVault { get; set; }
    }
}