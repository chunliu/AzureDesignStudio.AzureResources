// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine scale set operating system disk.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetOSDisk
    {
        /// <summary>
        /// Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**.
        /// </summary>
        [JsonPropertyName("caching")]
        public string Caching { get; set; }

        /// <summary>
        /// Specifies how the virtual machines in the scale set should be created.<br><br> The only allowed value is: **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described.
        /// </summary>
        [Required]
        [JsonPropertyName("createOption")]
        public string CreateOption { get; set; }

        /// <summary>
        /// Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion (This feature is available for VMSS with Flexible OrchestrationMode only). <br><br> Possible values: <br><br> **Delete** If this value is used, the OS disk is deleted when VMSS Flex VM is deleted.<br><br> **Detach** If this value is used, the OS disk is retained after VMSS Flex VM is deleted. <br><br> The default value is set to **Delete**. For an Ephemeral OS Disk, the default value is set to **Delete**. User cannot change the delete option for Ephemeral OS Disk.
        /// </summary>
        [JsonPropertyName("deleteOption")]
        public string DeleteOption { get; set; }

        /// <summary>
        /// Describes the parameters of ephemeral disk settings that can be specified for operating system disk. <br><br> NOTE: The ephemeral disk settings can only be specified for managed disk.
        /// </summary>
        [JsonPropertyName("diffDiskSettings")]
        public DiffDiskSettings DiffDiskSettings { get; set; }

        /// <summary>
        /// Specifies the size of the operating system disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. <br><br> This value cannot be larger than 1023 GB
        /// </summary>
        [JsonPropertyName("diskSizeGB")]
        public int DiskSizeGB { get; set; }

        /// <summary>
        /// Describes the uri of a disk.
        /// </summary>
        [JsonPropertyName("image")]
        public VirtualHardDisk Image { get; set; }

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
        /// This property allows you to specify the type of the OS that is included in the disk if creating a VM from user-image or a specialized VHD. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**.
        /// </summary>
        [JsonPropertyName("osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Specifies the container urls that are used to store operating system disks for the scale set.
        /// </summary>
        [JsonPropertyName("vhdContainers")]
        public IList<string> VhdContainers { get; set; }

        /// <summary>
        /// Specifies whether writeAccelerator should be enabled or disabled on the disk.
        /// </summary>
        [JsonPropertyName("writeAcceleratorEnabled")]
        public bool WriteAcceleratorEnabled { get; set; }
    }
}