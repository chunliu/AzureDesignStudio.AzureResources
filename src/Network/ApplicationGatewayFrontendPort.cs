using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Frontend port of an application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayFrontendPort
    {
        /// <summary>
        /// Properties of the application gateway frontend port.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayFrontendPortPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the frontend port that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}