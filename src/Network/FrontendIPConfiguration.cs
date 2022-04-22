using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Frontend IP address of the load balancer.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FrontendIPConfiguration
    {
        /// <summary>
        /// Properties of the load balancer probe.
        /// </summary>
        [JsonPropertyName("properties")]
        public FrontendIPConfigurationPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within the set of frontend IP configurations used by the load balancer. This name can be used to access the resource.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A list of availability zones denoting the IP allocated for the resource needs to come from.
        /// </summary>
        [JsonPropertyName("zones")]
        public IList<string> Zones { get; set; }
    }
}