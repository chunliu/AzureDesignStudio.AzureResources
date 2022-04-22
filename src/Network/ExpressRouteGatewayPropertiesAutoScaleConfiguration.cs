using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Configuration for auto scaling.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfiguration
    {
        /// <summary>
        /// Minimum and maximum number of scale units to deploy.
        /// </summary>
        [JsonPropertyName("bounds")]
        public ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds Bounds { get; set; }
    }
}