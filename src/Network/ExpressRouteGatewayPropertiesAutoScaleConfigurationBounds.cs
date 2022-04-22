using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Minimum and maximum number of scale units to deploy.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds
    {
        /// <summary>
        /// Minimum number of scale units deployed for ExpressRoute gateway.
        /// </summary>
        [JsonPropertyName("min")]
        public int Min { get; set; }

        /// <summary>
        /// Maximum number of scale units deployed for ExpressRoute gateway.
        /// </summary>
        [JsonPropertyName("max")]
        public int Max { get; set; }
    }
}