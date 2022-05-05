// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of IP configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkInterfaceIPConfigurationPropertiesFormat
    {
        /// <summary>
        /// The reference to Virtual Network Taps.
        /// </summary>
        [JsonPropertyName("virtualNetworkTaps")]
        public IList<SubResource> VirtualNetworkTaps { get; set; }

        /// <summary>
        /// The reference to ApplicationGatewayBackendAddressPool resource.
        /// </summary>
        [JsonPropertyName("applicationGatewayBackendAddressPools")]
        public IList<SubResource> ApplicationGatewayBackendAddressPools { get; set; }

        /// <summary>
        /// The reference to LoadBalancerBackendAddressPool resource.
        /// </summary>
        [JsonPropertyName("loadBalancerBackendAddressPools")]
        public IList<SubResource> LoadBalancerBackendAddressPools { get; set; }

        /// <summary>
        /// A list of references of LoadBalancerInboundNatRules.
        /// </summary>
        [JsonPropertyName("loadBalancerInboundNatRules")]
        public IList<SubResource> LoadBalancerInboundNatRules { get; set; }

        /// <summary>
        /// Private IP address of the IP configuration.
        /// </summary>
        [JsonPropertyName("privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// The private IP address allocation method.
        /// </summary>
        [JsonPropertyName("privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [JsonPropertyName("privateIPAddressVersion")]
        public string PrivateIPAddressVersion { get; set; }

        /// <summary>
        /// Subnet bound to the IP configuration.
        /// </summary>
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Whether this is a primary customer address on the network interface.
        /// </summary>
        [JsonPropertyName("primary")]
        public bool Primary { get; set; }

        /// <summary>
        /// Public IP address bound to the IP configuration.
        /// </summary>
        [JsonPropertyName("publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Application security groups in which the IP configuration is included.
        /// </summary>
        [JsonPropertyName("applicationSecurityGroups")]
        public IList<SubResource> ApplicationSecurityGroups { get; set; }
    }
}