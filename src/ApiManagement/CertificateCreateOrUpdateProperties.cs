// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Parameters supplied to the CreateOrUpdate certificate operation.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CertificateCreateOrUpdateProperties
    {
        /// <summary>
        /// Base 64 encoded certificate using the application/x-pkcs12 representation.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// Create keyVault contract details.
        /// </summary>
        [JsonPropertyName("keyVault")]
        public KeyVaultContractCreateProperties KeyVault { get; set; }

        /// <summary>
        /// Password for the Certificate
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}