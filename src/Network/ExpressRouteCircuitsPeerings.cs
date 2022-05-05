// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/expressRouteCircuits/peerings
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteCircuitsPeerings : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/expressRouteCircuits/peerings";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the express route circuit peering.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ExpressRouteCircuitPeeringPropertiesFormat Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ExpressRouteCircuitsPeeringsConnections> Resources { get; set; }
    }
}