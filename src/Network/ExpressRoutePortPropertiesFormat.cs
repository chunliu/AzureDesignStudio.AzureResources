using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties specific to ExpressRoutePort resources.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRoutePortPropertiesFormat
    {
        /// <summary>
        /// The name of the peering location that the ExpressRoutePort is mapped to physically.
        /// </summary>
        [JsonPropertyName("peeringLocation")]
        public string PeeringLocation { get; set; }

        /// <summary>
        /// Bandwidth of procured ports in Gbps.
        /// </summary>
        [JsonPropertyName("bandwidthInGbps")]
        public int BandwidthInGbps { get; set; }

        /// <summary>
        /// Encapsulation method on physical ports.
        /// </summary>
        [JsonPropertyName("encapsulation")]
        public string Encapsulation { get; set; }

        /// <summary>
        /// The set of physical links of the ExpressRoutePort resource.
        /// </summary>
        [JsonPropertyName("links")]
        public IList<ExpressRouteLink> Links { get; set; }
    }
}