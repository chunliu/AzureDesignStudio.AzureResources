// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a virtual machine scale set virtual machine.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetVMProperties
    {
        /// <summary>
        /// Enables or disables a capability on the virtual machine or virtual machine scale set.
        /// </summary>
        [JsonPropertyName("additionalCapabilities")]
        public AdditionalCapabilities AdditionalCapabilities { get; set; }
        [JsonPropertyName("availabilitySet")]
        public SubResource AvailabilitySet { get; set; }

        /// <summary>
        /// Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
        /// </summary>
        [JsonPropertyName("diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Specifies the hardware settings for the virtual machine.
        /// </summary>
        [JsonPropertyName("hardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        /// <summary>
        /// Specifies that the image or disk that is being used was licensed on-premises. <br><br> Possible values for Windows Server operating system are: <br><br> Windows_Client <br><br> Windows_Server <br><br> Possible values for Linux Server operating system are: <br><br> RHEL_BYOS (for RHEL) <br><br> SLES_BYOS (for SUSE) <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) <br><br> [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) <br><br> Minimum api-version: 2015-06-15
        /// </summary>
        [JsonPropertyName("licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Specifies the network interfaces or the networking configuration of the virtual machine.
        /// </summary>
        [JsonPropertyName("networkProfile")]
        public NetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Describes a virtual machine scale set VM network profile.
        /// </summary>
        [JsonPropertyName("networkProfileConfiguration")]
        public VirtualMachineScaleSetVMNetworkProfileConfiguration NetworkProfileConfiguration { get; set; }

        /// <summary>
        /// Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is provisioned.
        /// </summary>
        [JsonPropertyName("osProfile")]
        public OSProfile OsProfile { get; set; }

        /// <summary>
        /// The protection policy of a virtual machine scale set VM.
        /// </summary>
        [JsonPropertyName("protectionPolicy")]
        public VirtualMachineScaleSetVMProtectionPolicy ProtectionPolicy { get; set; }

        /// <summary>
        /// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
        /// </summary>
        [JsonPropertyName("securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Specifies the storage settings for the virtual machine disks.
        /// </summary>
        [JsonPropertyName("storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// UserData for the VM, which must be base-64 encoded. Customer should not pass any secrets in here. <br><br>Minimum api-version: 2021-03-01
        /// </summary>
        [JsonPropertyName("userData")]
        public string UserData { get; set; }
    }
}