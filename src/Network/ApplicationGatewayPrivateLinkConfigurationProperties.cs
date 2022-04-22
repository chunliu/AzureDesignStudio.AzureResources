using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of private link configuration on an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayPrivateLinkConfigurationProperties
    {
        /// <summary>
        /// An array of application gateway private link ip configurations.
        /// </summary>
        [JsonPropertyName("ipConfigurations")]
        public IList<ApplicationGatewayPrivateLinkIpConfiguration> IpConfigurations { get; set; }
    }
}