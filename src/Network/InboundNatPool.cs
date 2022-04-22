using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Inbound NAT pool of the load balancer.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class InboundNatPool
    {
        /// <summary>
        /// Properties of load balancer inbound nat pool.
        /// </summary>
        [JsonPropertyName("properties")]
        public InboundNatPoolPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within the set of inbound NAT pools used by the load balancer. This name can be used to access the resource.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}