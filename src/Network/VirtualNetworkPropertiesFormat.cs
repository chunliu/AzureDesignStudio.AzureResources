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
    /// Properties of the virtual network.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualNetworkPropertiesFormat
    {
        /// <summary>
        /// The AddressSpace that contains an array of IP address ranges that can be used by subnets.
        /// </summary>
        [Required]
        [JsonPropertyName("addressSpace")]
        public AddressSpace AddressSpace { get; set; }

        /// <summary>
        /// The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.
        /// </summary>
        [JsonPropertyName("dhcpOptions")]
        public DhcpOptions DhcpOptions { get; set; }

        /// <summary>
        /// A list of subnets in a Virtual Network.
        /// </summary>
        [JsonPropertyName("subnets")]
        public IList<Subnet> Subnets { get; set; }

        /// <summary>
        /// A list of peerings in a Virtual Network.
        /// </summary>
        [JsonPropertyName("virtualNetworkPeerings")]
        public IList<VirtualNetworkPeering> VirtualNetworkPeerings { get; set; }

        /// <summary>
        /// Indicates if DDoS protection is enabled for all the protected resources in the virtual network. It requires a DDoS protection plan associated with the resource.
        /// </summary>
        [JsonPropertyName("enableDdosProtection")]
        public bool EnableDdosProtection { get; set; }

        /// <summary>
        /// Indicates if VM protection is enabled for all the subnets in the virtual network.
        /// </summary>
        [JsonPropertyName("enableVmProtection")]
        public bool EnableVmProtection { get; set; }

        /// <summary>
        /// The DDoS protection plan associated with the virtual network.
        /// </summary>
        [JsonPropertyName("ddosProtectionPlan")]
        public SubResource DdosProtectionPlan { get; set; }

        /// <summary>
        /// Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.
        /// </summary>
        [JsonPropertyName("bgpCommunities")]
        public VirtualNetworkBgpCommunities BgpCommunities { get; set; }

        /// <summary>
        /// Array of IpAllocation which reference this VNET.
        /// </summary>
        [JsonPropertyName("ipAllocations")]
        public IList<SubResource> IpAllocations { get; set; }
    }
}