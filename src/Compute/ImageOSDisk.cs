// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes an Operating System disk.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ImageOSDisk
    {
        /// <summary>
        /// The Virtual Hard Disk.
        /// </summary>
        [JsonPropertyName("blobUri")]
        public string BlobUri { get; set; }

        /// <summary>
        /// Specifies the caching requirements. <br><br> Possible values are: <br><br> **None** <br><br> **ReadOnly** <br><br> **ReadWrite** <br><br> Default: **None for Standard storage. ReadOnly for Premium storage**.
        /// </summary>
        [JsonPropertyName("caching")]
        public string Caching { get; set; }

        /// <summary>
        /// Describes the parameter of customer managed disk encryption set resource id that can be specified for disk. <br><br> NOTE: The disk encryption set resource id can only be specified for managed disk. Please refer https://aka.ms/mdssewithcmkoverview for more details.
        /// </summary>
        [JsonPropertyName("diskEncryptionSet")]
        public DiskEncryptionSetParameters DiskEncryptionSet { get; set; }

        /// <summary>
        /// Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. <br><br> This value cannot be larger than 1023 GB
        /// </summary>
        [JsonPropertyName("diskSizeGB")]
        public int DiskSizeGB { get; set; }
        [JsonPropertyName("managedDisk")]
        public SubResource ManagedDisk { get; set; }

        /// <summary>
        /// The OS State.
        /// </summary>
        [Required]
        [JsonPropertyName("osState")]
        public string OsState { get; set; }

        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**.
        /// </summary>
        [Required]
        [JsonPropertyName("osType")]
        public string OsType { get; set; }
        [JsonPropertyName("snapshot")]
        public SubResource Snapshot { get; set; }

        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [JsonPropertyName("storageAccountType")]
        public string StorageAccountType { get; set; }
    }
}