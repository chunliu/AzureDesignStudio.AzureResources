using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Microsoft.Storage/storageAccounts/encryptionScopes
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class StorageAccountsEncryptionScopes : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-06-01";

        /// <summary>
        /// Properties of the encryption scope.
        /// </summary>
        [JsonPropertyName("properties")]
        public EncryptionScopeProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Storage/storageAccounts/encryptionScopes";
    }
}