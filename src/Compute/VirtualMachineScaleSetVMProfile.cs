// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetVMProfile
    {
        /// <summary>
        /// Contains the list of gallery applications that should be made available to the VM/VMSS
        /// </summary>
        [JsonPropertyName("applicationProfile")]
        public ApplicationProfile ApplicationProfile { get; set; }

        /// <summary>
        /// Specifies the billing related details of a Azure Spot VM or VMSS. <br><br>Minimum api-version: 2019-03-01.
        /// </summary>
        [JsonPropertyName("billingProfile")]
        public BillingProfile BillingProfile { get; set; }

        /// <summary>
        /// The parameters of a capacity reservation Profile.
        /// </summary>
        [JsonPropertyName("capacityReservation")]
        public CapacityReservationProfile CapacityReservation { get; set; }

        /// <summary>
        /// Specifies the boot diagnostic settings state. <br><br>Minimum api-version: 2015-06-15.
        /// </summary>
        [JsonPropertyName("diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. <br><br>For Azure Spot virtual machines, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2019-03-01. <br><br>For Azure Spot scale sets, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2017-10-30-preview.
        /// </summary>
        [JsonPropertyName("evictionPolicy")]
        public string EvictionPolicy { get; set; }

        /// <summary>
        /// Describes a virtual machine scale set extension profile.
        /// </summary>
        [JsonPropertyName("extensionProfile")]
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }

        /// <summary>
        /// Specifies that the image or disk that is being used was licensed on-premises. <br><br> Possible values for Windows Server operating system are: <br><br> Windows_Client <br><br> Windows_Server <br><br> Possible values for Linux Server operating system are: <br><br> RHEL_BYOS (for RHEL) <br><br> SLES_BYOS (for SUSE) <br><br> For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) <br><br> [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) <br><br> Minimum api-version: 2015-06-15
        /// </summary>
        [JsonPropertyName("licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Describes a virtual machine scale set network profile.
        /// </summary>
        [JsonPropertyName("networkProfile")]
        public VirtualMachineScaleSetNetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Describes a virtual machine scale set OS profile.
        /// </summary>
        [JsonPropertyName("osProfile")]
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }

        /// <summary>
        /// Specifies the priority for the virtual machines in the scale set. <br><br>Minimum api-version: 2017-10-30-preview.
        /// </summary>
        [JsonPropertyName("priority")]
        public string Priority { get; set; }
        [JsonPropertyName("scheduledEventsProfile")]
        public ScheduledEventsProfile ScheduledEventsProfile { get; set; }

        /// <summary>
        /// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
        /// </summary>
        [JsonPropertyName("securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Describes a virtual machine scale set storage profile.
        /// </summary>
        [JsonPropertyName("storageProfile")]
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// UserData for the virtual machines in the scale set, which must be base-64 encoded. Customer should not pass any secrets in here. <br><br>Minimum api-version: 2021-03-01
        /// </summary>
        [JsonPropertyName("userData")]
        public string UserData { get; set; }
    }
}