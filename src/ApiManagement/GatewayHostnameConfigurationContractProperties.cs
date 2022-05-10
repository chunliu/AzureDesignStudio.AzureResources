// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Gateway hostname configuration details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GatewayHostnameConfigurationContractProperties
    {
        /// <summary>
        /// Identifier of Certificate entity that will be used for TLS connection establishment
        /// </summary>
        [JsonPropertyName("certificateId")]
        public string CertificateId { get; set; }

        /// <summary>
        /// Hostname value. Supports valid domain name, partial or full wildcard
        /// </summary>
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Specifies if HTTP/2.0 is supported
        /// </summary>
        [JsonPropertyName("http2Enabled")]
        public bool Http2Enabled { get; set; }

        /// <summary>
        /// Determines whether gateway requests client certificate
        /// </summary>
        [JsonPropertyName("negotiateClientCertificate")]
        public bool NegotiateClientCertificate { get; set; }

        /// <summary>
        /// Specifies if TLS 1.0 is supported
        /// </summary>
        [JsonPropertyName("tls10Enabled")]
        public bool Tls10Enabled { get; set; }

        /// <summary>
        /// Specifies if TLS 1.1 is supported
        /// </summary>
        [JsonPropertyName("tls11Enabled")]
        public bool Tls11Enabled { get; set; }
    }
}