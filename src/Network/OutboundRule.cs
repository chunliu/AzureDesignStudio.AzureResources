using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Outbound rule of the load balancer.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class OutboundRule
    {
        /// <summary>
        /// Properties of load balancer outbound rule.
        /// </summary>
        [JsonPropertyName("properties")]
        public OutboundRulePropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within the set of outbound rules used by the load balancer. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}