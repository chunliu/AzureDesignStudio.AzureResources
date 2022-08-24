// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class KeyForDiskEncryptionSet
    {
        /// <summary>
        /// Fully versioned Key Url pointing to a key in KeyVault. Version segment of the Url is required regardless of rotationToLatestKeyVersionEnabled value.
        /// </summary>
        [Required]
        [JsonPropertyName("keyUrl")]
        public string KeyUrl { get; set; }

        /// <summary>
        /// The vault id is an Azure Resource Manager Resource id in the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
        /// </summary>
        [JsonPropertyName("sourceVault")]
        public SourceVault SourceVault { get; set; }
    }
}