// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Contains ServiceProviderProperties in an ExpressRouteCircuit.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteCircuitServiceProviderProperties
    {
        /// <summary>
        /// The serviceProviderName.
        /// </summary>
        [JsonPropertyName("serviceProviderName")]
        public string ServiceProviderName { get; set; }

        /// <summary>
        /// The peering location.
        /// </summary>
        [JsonPropertyName("peeringLocation")]
        public string PeeringLocation { get; set; }

        /// <summary>
        /// The BandwidthInMbps.
        /// </summary>
        [JsonPropertyName("bandwidthInMbps")]
        public int BandwidthInMbps { get; set; }
    }
}