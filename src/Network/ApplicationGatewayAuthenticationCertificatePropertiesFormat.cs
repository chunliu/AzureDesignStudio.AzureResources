using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Authentication certificates properties of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayAuthenticationCertificatePropertiesFormat
    {
        /// <summary>
        /// Certificate public data.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}