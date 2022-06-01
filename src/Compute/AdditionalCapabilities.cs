// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Enables or disables a capability on the virtual machine or virtual machine scale set.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AdditionalCapabilities
    {
        /// <summary>
        /// The flag that enables or disables hibernation capability on the VM.
        /// </summary>
        [JsonPropertyName("hibernationEnabled")]
        public bool HibernationEnabled { get; set; }

        /// <summary>
        /// The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS. Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled.
        /// </summary>
        [JsonPropertyName("ultraSSDEnabled")]
        public bool UltraSSDEnabled { get; set; }
    }
}