// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// ExpressRoute gateway resource properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteGatewayProperties
    {
        /// <summary>
        /// Configuration for auto scaling.
        /// </summary>
        [JsonPropertyName("autoScaleConfiguration")]
        public ExpressRouteGatewayPropertiesAutoScaleConfiguration AutoScaleConfiguration { get; set; }

        /// <summary>
        /// The Virtual Hub where the ExpressRoute gateway is or will be deployed.
        /// </summary>
        [Required]
        [JsonPropertyName("virtualHub")]
        public SubResource VirtualHub { get; set; }
    }
}