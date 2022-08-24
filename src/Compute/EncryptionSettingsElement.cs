// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Encryption settings for one disk volume.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class EncryptionSettingsElement
    {
        /// <summary>
        /// Key Vault Secret Url and vault id of the encryption key 
        /// </summary>
        [JsonPropertyName("diskEncryptionKey")]
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }

        /// <summary>
        /// Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey
        /// </summary>
        [JsonPropertyName("keyEncryptionKey")]
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }
    }
}