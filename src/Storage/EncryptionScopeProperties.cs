// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Properties of the encryption scope.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class EncryptionScopeProperties
    {
        /// <summary>
        /// The key vault properties for the encryption scope. This is a required field if encryption scope 'source' attribute is set to 'Microsoft.KeyVault'.
        /// </summary>
        [JsonPropertyName("keyVaultProperties")]
        public EncryptionScopeKeyVaultProperties KeyVaultProperties { get; set; }

        /// <summary>
        /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
        /// </summary>
        [JsonPropertyName("requireInfrastructureEncryption")]
        public bool RequireInfrastructureEncryption { get; set; }

        /// <summary>
        /// The provider for the encryption scope. Possible values (case-insensitive):  Microsoft.Storage, Microsoft.KeyVault.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// The state of the encryption scope. Possible values (case-insensitive):  Enabled, Disabled.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}