// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Inbound NAT rule of the load balancer.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class InboundNatRule
    {
        /// <summary>
        /// Properties of load balancer inbound nat rule.
        /// </summary>
        [JsonPropertyName("properties")]
        public InboundNatRulePropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name can be used to access the resource.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}