// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Configuration for auto scaling.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfiguration
    {
        /// <summary>
        /// Minimum and maximum number of scale units to deploy.
        /// </summary>
        [JsonPropertyName("bounds")]
        public ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds Bounds { get; set; }
    }
}