using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Application gateway client authentication configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayClientAuthConfiguration
    {
        /// <summary>
        /// Verify client certificate issuer name on the application gateway.
        /// </summary>
        [JsonPropertyName("verifyClientCertIssuerDN")]
        public bool VerifyClientCertIssuerDN { get; set; }
    }
}