using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The application gateway private link ip configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayPrivateLinkIpConfiguration
    {
        /// <summary>
        /// Properties of an application gateway private link ip configuration.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayPrivateLinkIpConfigurationProperties Properties { get; set; }

        /// <summary>
        /// The name of application gateway private link ip configuration.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}