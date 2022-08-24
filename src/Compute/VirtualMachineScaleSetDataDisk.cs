// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine scale set data disk.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetDataDisk
    {
        /// <summary>
        /// Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**.
        /// </summary>
        [JsonPropertyName("caching")]
        public string Caching { get; set; }

        /// <summary>
        /// The create option.
        /// </summary>
        [Required]
        [JsonPropertyName("createOption")]
        public string CreateOption { get; set; }

        /// <summary>
        /// Specifies whether data disk should be deleted or detached upon VMSS Flex deletion (This feature is available for VMSS with Flexible OrchestrationMode only).<br><br> Possible values: <br><br> **Delete** If this value is used, the data disk is deleted when the VMSS Flex VM is deleted.<br><br> **Detach** If this value is used, the data disk is retained after VMSS Flex VM is deleted.<br><br> The default value is set to **Delete**.
        /// </summary>
        [JsonPropertyName("deleteOption")]
        public string DeleteOption { get; set; }

        /// <summary>
        /// Specifies the Read-Write IOPS for the managed disk. Should be used only when StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB.
        /// </summary>
        [JsonPropertyName("diskIOPSReadWrite")]
        public int DiskIOPSReadWrite { get; set; }

        /// <summary>
        /// Specifies the bandwidth in MB per second for the managed disk. Should be used only when StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB.
        /// </summary>
        [JsonPropertyName("diskMBpsReadWrite")]
        public int DiskMBpsReadWrite { get; set; }

        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. <br><br> This value cannot be larger than 1023 GB
        /// </summary>
        [JsonPropertyName("diskSizeGB")]
        public int DiskSizeGB { get; set; }

        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM.
        /// </summary>
        [Required]
        [JsonPropertyName("lun")]
        public int Lun { get; set; }

        /// <summary>
        /// Describes the parameters of a ScaleSet managed disk.
        /// </summary>
        [JsonPropertyName("managedDisk")]
        public VirtualMachineScaleSetManagedDiskParameters ManagedDisk { get; set; }

        /// <summary>
        /// The disk name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether writeAccelerator should be enabled or disabled on the disk.
        /// </summary>
        [JsonPropertyName("writeAcceleratorEnabled")]
        public bool WriteAcceleratorEnabled { get; set; }
    }
}