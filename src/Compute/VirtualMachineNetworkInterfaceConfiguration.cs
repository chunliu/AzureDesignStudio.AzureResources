// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine network interface configurations.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineNetworkInterfaceConfiguration
    {
        /// <summary>
        /// The network interface configuration name.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Describes a virtual machine network profile's IP configuration.
        /// </summary>
        [JsonPropertyName("properties")]
        public VirtualMachineNetworkInterfaceConfigurationProperties Properties { get; set; }
    }
}