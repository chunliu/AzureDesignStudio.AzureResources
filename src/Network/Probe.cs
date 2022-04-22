using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// A load balancer probe.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Probe
    {
        /// <summary>
        /// Properties of load balancer probe.
        /// </summary>
        [JsonPropertyName("properties")]
        public ProbePropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within the set of probes used by the load balancer. This name can be used to access the resource.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}