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
    /// Microsoft.Network/loadBalancers
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoadBalancers : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/loadBalancers";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// The extended location of the load balancer.
        /// </summary>
        [JsonPropertyName("extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// The load balancer SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public LoadBalancerSku Sku { get; set; }

        /// <summary>
        /// Properties of load balancer.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public LoadBalancerPropertiesFormat Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<LoadBalancersInboundNatRules> Resources { get; set; }
    }
}