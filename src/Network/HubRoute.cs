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
    /// RouteTable route.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class HubRoute
    {
        /// <summary>
        /// The name of the Route that is unique within a RouteTable. This name can be used to access this route.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of destinations (eg: CIDR, ResourceId, Service).
        /// </summary>
        [Required]
        [JsonPropertyName("destinationType")]
        public string DestinationType { get; set; }

        /// <summary>
        /// List of all destinations.
        /// </summary>
        [Required]
        [JsonPropertyName("destinations")]
        public IList<string> Destinations { get; set; }

        /// <summary>
        /// The type of next hop (eg: ResourceId).
        /// </summary>
        [Required]
        [JsonPropertyName("nextHopType")]
        public string NextHopType { get; set; }

        /// <summary>
        /// NextHop resource ID.
        /// </summary>
        [Required]
        [JsonPropertyName("nextHop")]
        public string NextHop { get; set; }
    }
}