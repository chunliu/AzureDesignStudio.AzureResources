using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Encryption identity for the storage account.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class EncryptionIdentity
    {
        /// <summary>
        /// Resource identifier of the UserAssigned identity to be associated with server-side encryption on the storage account.
        /// </summary>
        [JsonPropertyName("userAssignedIdentity")]
        public string UserAssignedIdentity { get; set; }
    }
}