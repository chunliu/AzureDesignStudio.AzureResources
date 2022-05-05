// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the ExpressRouteConnection subresource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteConnectionProperties
    {
        /// <summary>
        /// The ExpressRoute circuit peering.
        /// </summary>
        [Required]
        [JsonPropertyName("expressRouteCircuitPeering")]
        public SubResource ExpressRouteCircuitPeering { get; set; }

        /// <summary>
        /// Authorization key to establish the connection.
        /// </summary>
        [JsonPropertyName("authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// The routing weight associated to the connection.
        /// </summary>
        [JsonPropertyName("routingWeight")]
        public int RoutingWeight { get; set; }

        /// <summary>
        /// Enable internet security.
        /// </summary>
        [JsonPropertyName("enableInternetSecurity")]
        public bool EnableInternetSecurity { get; set; }

        /// <summary>
        /// Enable FastPath to vWan Firewall hub.
        /// </summary>
        [JsonPropertyName("expressRouteGatewayBypass")]
        public bool ExpressRouteGatewayBypass { get; set; }

        /// <summary>
        /// The Routing Configuration indicating the associated and propagated route tables on this connection.
        /// </summary>
        [JsonPropertyName("routingConfiguration")]
        public RoutingConfiguration RoutingConfiguration { get; set; }
    }
}