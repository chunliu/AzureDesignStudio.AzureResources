// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Properties of server X509Names.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class X509CertificateName
    {
        /// <summary>
        /// Thumbprint for the Issuer of the Certificate.
        /// </summary>
        [JsonPropertyName("issuerCertificateThumbprint")]
        public string IssuerCertificateThumbprint { get; set; }

        /// <summary>
        /// Common Name of the Certificate.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}