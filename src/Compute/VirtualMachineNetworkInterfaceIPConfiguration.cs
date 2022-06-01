// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine network profile's IP configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineNetworkInterfaceIPConfiguration
    {
        /// <summary>
        /// The IP configuration name.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Describes a virtual machine network interface IP configuration properties.
        /// </summary>
        [JsonPropertyName("properties")]
        public VirtualMachineNetworkInterfaceIPConfigurationProperties Properties { get; set; }
    }
}