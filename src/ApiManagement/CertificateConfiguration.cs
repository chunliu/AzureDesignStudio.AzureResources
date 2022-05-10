// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Certificate configuration which consist of non-trusted intermediates and root certificates.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CertificateConfiguration
    {
        /// <summary>
        /// SSL certificate information.
        /// </summary>
        [JsonPropertyName("certificate")]
        public CertificateInformation Certificate { get; set; }

        /// <summary>
        /// Certificate Password.
        /// </summary>
        [JsonPropertyName("certificatePassword")]
        public string CertificatePassword { get; set; }

        /// <summary>
        /// Base64 Encoded certificate.
        /// </summary>
        [JsonPropertyName("encodedCertificate")]
        public string EncodedCertificate { get; set; }

        /// <summary>
        /// The System.Security.Cryptography.x509certificates.StoreName certificate store location. Only Root and CertificateAuthority are valid locations.
        /// </summary>
        [Required]
        [JsonPropertyName("storeName")]
        public string StoreName { get; set; }
    }
}