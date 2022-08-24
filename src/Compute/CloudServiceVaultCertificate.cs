// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the role instance.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServiceVaultCertificate
    {
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a secret.
        /// </summary>
        [JsonPropertyName("certificateUrl")]
        public string CertificateUrl { get; set; }
    }
}