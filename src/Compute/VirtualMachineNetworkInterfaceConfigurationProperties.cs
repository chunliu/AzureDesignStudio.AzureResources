// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine network profile's IP configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineNetworkInterfaceConfigurationProperties
    {
        /// <summary>
        /// Specify what happens to the network interface when the VM is deleted.
        /// </summary>
        [JsonPropertyName("deleteOption")]
        public string DeleteOption { get; set; }

        /// <summary>
        /// Describes a virtual machines network configuration's DNS settings.
        /// </summary>
        [JsonPropertyName("dnsSettings")]
        public VirtualMachineNetworkInterfaceDnsSettingsConfiguration DnsSettings { get; set; }
        [JsonPropertyName("dscpConfiguration")]
        public SubResource DscpConfiguration { get; set; }

        /// <summary>
        /// Specifies whether the network interface is accelerated networking-enabled.
        /// </summary>
        [JsonPropertyName("enableAcceleratedNetworking")]
        public bool EnableAcceleratedNetworking { get; set; }

        /// <summary>
        /// Specifies whether the network interface is FPGA networking-enabled.
        /// </summary>
        [JsonPropertyName("enableFpga")]
        public bool EnableFpga { get; set; }

        /// <summary>
        /// Whether IP forwarding enabled on this NIC.
        /// </summary>
        [JsonPropertyName("enableIPForwarding")]
        public bool EnableIPForwarding { get; set; }

        /// <summary>
        /// Specifies the IP configurations of the network interface.
        /// </summary>
        [Required]
        [JsonPropertyName("ipConfigurations")]
        public IList<VirtualMachineNetworkInterfaceIPConfiguration> IpConfigurations { get; set; }
        [JsonPropertyName("networkSecurityGroup")]
        public SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more than 1 network interface.
        /// </summary>
        [JsonPropertyName("primary")]
        public bool Primary { get; set; }
    }
}