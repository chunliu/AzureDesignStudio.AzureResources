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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteCircuits_peerings : ResourceBase
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
        public IList<ExpressRouteCircuits_peerings_connections> Resources { get; set; }
    }
}