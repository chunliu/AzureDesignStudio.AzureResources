using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Trusted Root certificates of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayTrustedRootCertificate
    {
        /// <summary>
        /// Properties of the application gateway trusted root certificate.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayTrustedRootCertificatePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the trusted root certificate that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}