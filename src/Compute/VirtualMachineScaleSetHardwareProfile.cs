// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the hardware settings for the virtual machine scale set.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetHardwareProfile
    {
        /// <summary>
        /// Specifies VM Size Property settings on the virtual machine.
        /// </summary>
        [JsonPropertyName("vmSizeProperties")]
        public VMSizeProperties VmSizeProperties { get; set; }
    }
}