using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VirtualHubRouteTableV2 route.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualHubRouteV2
    {
        /// <summary>
        /// The type of destinations.
        /// </summary>
        [JsonPropertyName("destinationType")]
        public string DestinationType { get; set; }

        /// <summary>
        /// List of all destinations.
        /// </summary>
        [JsonPropertyName("destinations")]
        public IList<string> Destinations { get; set; }

        /// <summary>
        /// The type of next hops.
        /// </summary>
        [JsonPropertyName("nextHopType")]
        public string NextHopType { get; set; }

        /// <summary>
        /// NextHops ip address.
        /// </summary>
        [JsonPropertyName("nextHops")]
        public IList<string> NextHops { get; set; }
    }
}