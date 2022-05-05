// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the load balancer backend addresses.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoadBalancerBackendAddressPropertiesFormat
    {
        /// <summary>
        /// Reference to an existing virtual network.
        /// </summary>
        [JsonPropertyName("virtualNetwork")]
        public SubResource VirtualNetwork { get; set; }

        /// <summary>
        /// Reference to an existing subnet.
        /// </summary>
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// IP Address belonging to the referenced virtual network.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Reference to the frontend ip address configuration defined in regional loadbalancer.
        /// </summary>
        [JsonPropertyName("loadBalancerFrontendIPConfiguration")]
        public SubResource LoadBalancerFrontendIPConfiguration { get; set; }
    }
}