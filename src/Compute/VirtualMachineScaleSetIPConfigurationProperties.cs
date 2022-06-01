// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine scale set network profile's IP configuration properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetIPConfigurationProperties
    {
        /// <summary>
        /// Specifies an array of references to backend address pools of application gateways. A scale set can reference backend address pools of multiple application gateways. Multiple scale sets cannot use the same application gateway.
        /// </summary>
        [JsonPropertyName("applicationGatewayBackendAddressPools")]
        public IList<SubResource> ApplicationGatewayBackendAddressPools { get; set; }

        /// <summary>
        /// Specifies an array of references to application security group.
        /// </summary>
        [JsonPropertyName("applicationSecurityGroups")]
        public IList<SubResource> ApplicationSecurityGroups { get; set; }

        /// <summary>
        /// Specifies an array of references to backend address pools of load balancers. A scale set can reference backend address pools of one public and one internal load balancer. Multiple scale sets cannot use the same basic sku load balancer.
        /// </summary>
        [JsonPropertyName("loadBalancerBackendAddressPools")]
        public IList<SubResource> LoadBalancerBackendAddressPools { get; set; }

        /// <summary>
        /// Specifies an array of references to inbound Nat pools of the load balancers. A scale set can reference inbound nat pools of one public and one internal load balancer. Multiple scale sets cannot use the same basic sku load balancer.
        /// </summary>
        [JsonPropertyName("loadBalancerInboundNatPools")]
        public IList<SubResource> LoadBalancerInboundNatPools { get; set; }

        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more than 1 network interface.
        /// </summary>
        [JsonPropertyName("primary")]
        public bool Primary { get; set; }

        /// <summary>
        /// Available from Api-Version 2017-03-30 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [JsonPropertyName("privateIPAddressVersion")]
        public string PrivateIPAddressVersion { get; set; }

        /// <summary>
        /// Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration
        /// </summary>
        [JsonPropertyName("publicIPAddressConfiguration")]
        public VirtualMachineScaleSetPublicIPAddressConfiguration PublicIPAddressConfiguration { get; set; }

        /// <summary>
        /// The API entity reference.
        /// </summary>
        [JsonPropertyName("subnet")]
        public ApiEntityReference Subnet { get; set; }
    }
}