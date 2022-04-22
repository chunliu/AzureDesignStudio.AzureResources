using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of Frontend port of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayFrontendPortPropertiesFormat
    {
        /// <summary>
        /// Frontend port.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }
    }
}