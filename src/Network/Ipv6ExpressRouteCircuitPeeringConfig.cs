// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Contains IPv6 peering config.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Ipv6ExpressRouteCircuitPeeringConfig
    {
        /// <summary>
        /// The primary address prefix.
        /// </summary>
        [JsonPropertyName("primaryPeerAddressPrefix")]
        public string PrimaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// The secondary address prefix.
        /// </summary>
        [JsonPropertyName("secondaryPeerAddressPrefix")]
        public string SecondaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// The Microsoft peering configuration.
        /// </summary>
        [JsonPropertyName("microsoftPeeringConfig")]
        public ExpressRouteCircuitPeeringConfig MicrosoftPeeringConfig { get; set; }

        /// <summary>
        /// The reference to the RouteFilter resource.
        /// </summary>
        [JsonPropertyName("routeFilter")]
        public SubResource RouteFilter { get; set; }

        /// <summary>
        /// The state of peering.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}