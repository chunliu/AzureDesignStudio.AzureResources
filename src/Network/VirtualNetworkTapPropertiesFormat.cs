// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Virtual Network Tap properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualNetworkTapPropertiesFormat
    {
        /// <summary>
        /// The reference to the private IP Address of the collector nic that will receive the tap.
        /// </summary>
        [JsonPropertyName("destinationNetworkInterfaceIPConfiguration")]
        public SubResource DestinationNetworkInterfaceIPConfiguration { get; set; }

        /// <summary>
        /// The reference to the private IP address on the internal Load Balancer that will receive the tap.
        /// </summary>
        [JsonPropertyName("destinationLoadBalancerFrontEndIPConfiguration")]
        public SubResource DestinationLoadBalancerFrontEndIPConfiguration { get; set; }

        /// <summary>
        /// The VXLAN destination port that will receive the tapped traffic.
        /// </summary>
        [JsonPropertyName("destinationPort")]
        public int DestinationPort { get; set; }
    }
}