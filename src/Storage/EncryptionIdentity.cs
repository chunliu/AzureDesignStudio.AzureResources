// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Encryption identity for the storage account.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class EncryptionIdentity
    {
        /// <summary>
        /// ClientId of the multi-tenant application to be used in conjunction with the user-assigned identity for cross-tenant customer-managed-keys server-side encryption on the storage account.
        /// </summary>
        [JsonPropertyName("federatedIdentityClientId")]
        public string FederatedIdentityClientId { get; set; }

        /// <summary>
        /// Resource identifier of the UserAssigned identity to be associated with server-side encryption on the storage account.
        /// </summary>
        [JsonPropertyName("userAssignedIdentity")]
        public string UserAssignedIdentity { get; set; }
    }
}