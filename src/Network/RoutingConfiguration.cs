// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Routing Configuration indicating the associated and propagated route tables for this connection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RoutingConfiguration
    {
        /// <summary>
        /// The resource id RouteTable associated with this RoutingConfiguration.
        /// </summary>
        [JsonPropertyName("associatedRouteTable")]
        public SubResource AssociatedRouteTable { get; set; }

        /// <summary>
        /// The list of RouteTables to advertise the routes to.
        /// </summary>
        [JsonPropertyName("propagatedRouteTables")]
        public PropagatedRouteTable PropagatedRouteTables { get; set; }

        /// <summary>
        /// List of routes that control routing from VirtualHub into a virtual network connection.
        /// </summary>
        [JsonPropertyName("vnetRoutes")]
        public VnetRoute VnetRoutes { get; set; }
    }
}