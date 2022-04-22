using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Header configuration of the Actions set in Application Gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayHeaderConfiguration
    {
        /// <summary>
        /// Header name of the header configuration.
        /// </summary>
        [JsonPropertyName("headerName")]
        public string HeaderName { get; set; }

        /// <summary>
        /// Header value of the header configuration.
        /// </summary>
        [JsonPropertyName("headerValue")]
        public string HeaderValue { get; set; }
    }
}