// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class KeyVaultAndKeyReference
    {
        /// <summary>
        /// Url pointing to a key or secret in KeyVault
        /// </summary>
        [Required]
        [JsonPropertyName("keyUrl")]
        public string KeyUrl { get; set; }

        /// <summary>
        /// The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// </summary>
        [Required]
        [JsonPropertyName("sourceVault")]
        public SourceVault SourceVault { get; set; }
    }
}