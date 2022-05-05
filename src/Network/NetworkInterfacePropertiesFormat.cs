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
    /// NetworkInterface properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkInterfacePropertiesFormat
    {
        /// <summary>
        /// The reference to the NetworkSecurityGroup resource.
        /// </summary>
        [JsonPropertyName("networkSecurityGroup")]
        public SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// A list of IPConfigurations of the network interface.
        /// </summary>
        [Required]
        [JsonPropertyName("ipConfigurations")]
        public IList<NetworkInterfaceIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// The DNS settings in network interface.
        /// </summary>
        [JsonPropertyName("dnsSettings")]
        public NetworkInterfaceDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// If the network interface is accelerated networking enabled.
        /// </summary>
        [JsonPropertyName("enableAcceleratedNetworking")]
        public bool EnableAcceleratedNetworking { get; set; }

        /// <summary>
        /// Indicates whether IP forwarding is enabled on this network interface.
        /// </summary>
        [JsonPropertyName("enableIPForwarding")]
        public bool EnableIPForwarding { get; set; }
    }
}