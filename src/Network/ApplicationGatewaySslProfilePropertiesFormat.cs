using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of SSL profile of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewaySslProfilePropertiesFormat
    {
        /// <summary>
        /// Array of references to application gateway trusted client certificates.
        /// </summary>
        [JsonPropertyName("trustedClientCertificates")]
        public IList<SubResource> TrustedClientCertificates { get; set; }

        /// <summary>
        /// SSL policy of the application gateway resource.
        /// </summary>
        [JsonPropertyName("sslPolicy")]
        public ApplicationGatewaySslPolicy SslPolicy { get; set; }

        /// <summary>
        /// Client authentication configuration of the application gateway resource.
        /// </summary>
        [JsonPropertyName("clientAuthConfiguration")]
        public ApplicationGatewayClientAuthConfiguration ClientAuthConfiguration { get; set; }
    }
}