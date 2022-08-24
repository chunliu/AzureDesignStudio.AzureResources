// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// CustomDnsSuffixConfiguration resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CustomDnsSuffixConfigurationProperties
    {
        /// <summary>
        /// The URL referencing the Azure Key Vault certificate secret that should be used as the default SSL/TLS certificate for sites with the custom domain suffix.
        /// </summary>
        [JsonPropertyName("certificateUrl")]
        public string CertificateUrl { get; set; }

        /// <summary>
        /// The default custom domain suffix to use for all sites deployed on the ASE.
        /// </summary>
        [JsonPropertyName("dnsSuffix")]
        public string DnsSuffix { get; set; }

        /// <summary>
        /// The user-assigned identity to use for resolving the key vault certificate reference. If not specified, the system-assigned ASE identity will be used if available.
        /// </summary>
        [JsonPropertyName("keyVaultReferenceIdentity")]
        public string KeyVaultReferenceIdentity { get; set; }
    }
}