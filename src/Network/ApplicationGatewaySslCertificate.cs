using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// SSL certificates of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewaySslCertificate
    {
        /// <summary>
        /// Properties of the application gateway SSL certificate.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewaySslCertificatePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the SSL certificate that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}