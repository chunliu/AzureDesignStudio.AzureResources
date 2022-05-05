// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VirtualHubRouteTableV2.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualHubRouteTableV2Properties
    {
        /// <summary>
        /// List of all routes.
        /// </summary>
        [JsonPropertyName("routes")]
        public IList<VirtualHubRouteV2> Routes { get; set; }

        /// <summary>
        /// List of all connections attached to this route table v2.
        /// </summary>
        [JsonPropertyName("attachedConnections")]
        public IList<string> AttachedConnections { get; set; }
    }
}