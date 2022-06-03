// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the network interfaces or the networking configuration of the virtual machine.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkProfile
    {
        /// <summary>
        /// specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations.
        /// </summary>
        [JsonPropertyName("networkApiVersion")]
        public string NetworkApiVersion => "2020-11-01";

        /// <summary>
        /// Specifies the networking configurations that will be used to create the virtual machine networking resources.
        /// </summary>
        [JsonPropertyName("networkInterfaceConfigurations")]
        public IList<VirtualMachineNetworkInterfaceConfiguration> NetworkInterfaceConfigurations { get; set; }

        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the virtual machine.
        /// </summary>
        [JsonPropertyName("networkInterfaces")]
        public IList<NetworkInterfaceReference> NetworkInterfaces { get; set; }
    }
}