// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Specifies the peering configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteCircuitPeeringConfig
    {
        /// <summary>
        /// The reference to AdvertisedPublicPrefixes.
        /// </summary>
        [JsonPropertyName("advertisedPublicPrefixes")]
        public IList<string> AdvertisedPublicPrefixes { get; set; }

        /// <summary>
        /// The communities of bgp peering. Specified for microsoft peering.
        /// </summary>
        [JsonPropertyName("advertisedCommunities")]
        public IList<string> AdvertisedCommunities { get; set; }

        /// <summary>
        /// The legacy mode of the peering.
        /// </summary>
        [JsonPropertyName("legacyMode")]
        public int LegacyMode { get; set; }

        /// <summary>
        /// The CustomerASN of the peering.
        /// </summary>
        [JsonPropertyName("customerASN")]
        public int CustomerASN { get; set; }

        /// <summary>
        /// The RoutingRegistryName of the configuration.
        /// </summary>
        [JsonPropertyName("routingRegistryName")]
        public string RoutingRegistryName { get; set; }
    }
}