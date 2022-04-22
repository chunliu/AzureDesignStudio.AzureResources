using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Authentication certificates of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayAuthenticationCertificate
    {
        /// <summary>
        /// Properties of the application gateway authentication certificate.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayAuthenticationCertificatePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the authentication certificate that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}