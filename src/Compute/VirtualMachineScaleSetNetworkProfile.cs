// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine scale set network profile.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetNetworkProfile
    {
        /// <summary>
        /// The API entity reference.
        /// </summary>
        [JsonPropertyName("healthProbe")]
        public ApiEntityReference HealthProbe { get; set; }

        /// <summary>
        /// specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations for Virtual Machine Scale Set with orchestration mode 'Flexible'.
        /// </summary>
        [JsonPropertyName("networkApiVersion")]
        public string NetworkApiVersion { get; set; }

        /// <summary>
        /// The list of network configurations.
        /// </summary>
        [JsonPropertyName("networkInterfaceConfigurations")]
        public IList<VirtualMachineScaleSetNetworkConfiguration> NetworkInterfaceConfigurations { get; set; }
    }
}