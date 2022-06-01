// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a Encryption Settings for a Disk
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DiskEncryptionSettings
    {
        /// <summary>
        /// Describes a reference to Key Vault Secret
        /// </summary>
        [JsonPropertyName("diskEncryptionKey")]
        public KeyVaultSecretReference DiskEncryptionKey { get; set; }

        /// <summary>
        /// Specifies whether disk encryption should be enabled on the virtual machine.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Describes a reference to Key Vault Key
        /// </summary>
        [JsonPropertyName("keyEncryptionKey")]
        public KeyVaultKeyReference KeyEncryptionKey { get; set; }
    }
}