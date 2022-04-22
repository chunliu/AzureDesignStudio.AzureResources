using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/expressRouteCrossConnections/peerings
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteCrossConnections_peerings : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/expressRouteCrossConnections/peerings";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the express route cross connection peering.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ExpressRouteCrossConnectionPeeringProperties Properties { get; set; }
    }
}