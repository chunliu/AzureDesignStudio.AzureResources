using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Probe of the application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayProbe
    {
        /// <summary>
        /// Properties of the application gateway probe.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayProbePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the probe that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}