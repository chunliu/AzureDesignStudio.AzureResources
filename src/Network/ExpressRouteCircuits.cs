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
    /// Microsoft.Network/expressRouteCircuits
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteCircuits : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/expressRouteCircuits";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// The SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public ExpressRouteCircuitSku Sku { get; set; }

        /// <summary>
        /// Properties of the express route circuit.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ExpressRouteCircuitPropertiesFormat Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ExpressRouteCircuitsPeerings> Resources { get; set; }
    }
}