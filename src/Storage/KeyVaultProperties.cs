using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Properties of key vault.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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