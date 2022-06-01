// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine. <br><br>For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LinuxConfiguration
    {
        /// <summary>
        /// Specifies whether password authentication should be disabled.
        /// </summary>
        [JsonPropertyName("disablePasswordAuthentication")]
        public bool DisablePasswordAuthentication { get; set; }

        /// <summary>
        /// Specifies settings related to VM Guest Patching on Linux.
        /// </summary>
        [JsonPropertyName("patchSettings")]
        public LinuxPatchSettings PatchSettings { get; set; }

        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual machine. <br><br> When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later.
        /// </summary>
        [JsonPropertyName("provisionVMAgent")]
        public bool ProvisionVMAgent { get; set; }

        /// <summary>
        /// SSH configuration for Linux based VMs running on Azure
        /// </summary>
        [JsonPropertyName("ssh")]
        public SshConfiguration Ssh { get; set; }
    }
}