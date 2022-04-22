using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Trusted client certificates of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayTrustedClientCertificate
    {
        /// <summary>
        /// Properties of the application gateway trusted client certificate.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayTrustedClientCertificatePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the trusted client certificate that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}