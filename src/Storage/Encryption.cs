// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The encryption settings on the storage account.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Encryption
    {
        /// <summary>
        /// Encryption identity for the storage account.
        /// </summary>
        [JsonPropertyName("identity")]
        public EncryptionIdentity Identity { get; set; }

        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
        /// </summary>
        [Required]
        [JsonPropertyName("keySource")]
        public string KeySource { get; set; }

        /// <summary>
        /// Properties of key vault.
        /// </summary>
        [JsonPropertyName("keyvaultproperties")]
        public KeyVaultProperties Keyvaultproperties { get; set; }

        /// <summary>
        /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
        /// </summary>
        [JsonPropertyName("requireInfrastructureEncryption")]
        public bool RequireInfrastructureEncryption { get; set; }

        /// <summary>
        /// A list of services that support encryption.
        /// </summary>
        [JsonPropertyName("services")]
        public EncryptionServices Services { get; set; }
    }
}