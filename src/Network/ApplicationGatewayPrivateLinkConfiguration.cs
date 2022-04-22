using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Private Link Configuration on an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayPrivateLinkConfiguration
    {
        /// <summary>
        /// Properties of the application gateway private link configuration.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayPrivateLinkConfigurationProperties Properties { get; set; }

        /// <summary>
        /// Name of the private link configuration that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}