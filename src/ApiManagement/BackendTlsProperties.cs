// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Properties controlling TLS Certificate Validation.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BackendTlsProperties
    {
        /// <summary>
        /// Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for this backend host.
        /// </summary>
        [JsonPropertyName("validateCertificateChain")]
        public bool ValidateCertificateChain { get; set; }

        /// <summary>
        /// Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for this backend host.
        /// </summary>
        [JsonPropertyName("validateCertificateName")]
        public bool ValidateCertificateName { get; set; }
    }
}