// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Create keyVault contract details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class KeyVaultContractCreateProperties
    {
        /// <summary>
        /// Null for SystemAssignedIdentity or Client Id for UserAssignedIdentity , which will be used to access key vault secret.
        /// </summary>
        [JsonPropertyName("identityClientId")]
        public string IdentityClientId { get; set; }

        /// <summary>
        /// Key vault secret identifier for fetching secret. Providing a versioned secret will prevent auto-refresh. This requires API Management service to be configured with aka.ms/apimmsi
        /// </summary>
        [JsonPropertyName("secretIdentifier")]
        public string SecretIdentifier { get; set; }
    }
}