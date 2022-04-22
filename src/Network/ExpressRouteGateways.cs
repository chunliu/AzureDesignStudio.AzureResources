using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/expressRouteGateways
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteGateways : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/expressRouteGateways";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the express route gateway.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ExpressRouteGatewayProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ExpressRouteGateways_expressRouteConnections> Resources { get; set; }
    }
}