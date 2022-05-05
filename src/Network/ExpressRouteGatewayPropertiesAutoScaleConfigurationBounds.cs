// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Minimum and maximum number of scale units to deploy.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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