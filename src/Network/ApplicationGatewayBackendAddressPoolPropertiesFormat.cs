using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of Backend Address Pool of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayBackendAddressPoolPropertiesFormat
    {
        /// <summary>
        /// Backend addresses.
        /// </summary>
        [JsonPropertyName("backendAddresses")]
        public IList<ApplicationGatewayBackendAddress> BackendAddresses { get; set; }
    }
}