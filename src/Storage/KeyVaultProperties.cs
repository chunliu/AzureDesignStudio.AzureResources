// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Properties of key vault.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class KeyVaultProperties
    {
        /// <summary>
        /// The name of KeyVault key.
        /// </summary>
        [JsonPropertyName("keyname")]
        public string Keyname { get; set; }

        /// <summary>
        /// The Uri of KeyVault.
        /// </summary>
        [JsonPropertyName("keyvaulturi")]
        public string Keyvaulturi { get; set; }

        /// <summary>
        /// The version of KeyVault key.
        /// </summary>
        [JsonPropertyName("keyversion")]
        public string Keyversion { get; set; }
    }
}