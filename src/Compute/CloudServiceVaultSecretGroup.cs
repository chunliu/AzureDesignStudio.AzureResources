// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a set of certificates which are all in the same Key Vault.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServiceVaultSecretGroup
    {
        [JsonPropertyName("sourceVault")]
        public SubResource SourceVault { get; set; }

        /// <summary>
        /// The list of key vault references in SourceVault which contain certificates.
        /// </summary>
        [JsonPropertyName("vaultCertificates")]
        public IList<CloudServiceVaultCertificate> VaultCertificates { get; set; }
    }
}