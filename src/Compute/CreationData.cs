// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Data used when creating a disk.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CreationData
    {
        /// <summary>
        /// This enumerates the possible sources of a disk's creation.
        /// </summary>
        [Required]
        [JsonPropertyName("createOption")]
        public string CreateOption { get; set; }

        /// <summary>
        /// The source image used for creating the disk.
        /// </summary>
        [JsonPropertyName("galleryImageReference")]
        public ImageDiskReference GalleryImageReference { get; set; }

        /// <summary>
        /// The source image used for creating the disk.
        /// </summary>
        [JsonPropertyName("imageReference")]
        public ImageDiskReference ImageReference { get; set; }

        /// <summary>
        /// Logical sector size in bytes for Ultra disks. Supported values are 512 ad 4096. 4096 is the default.
        /// </summary>
        [JsonPropertyName("logicalSectorSize")]
        public int LogicalSectorSize { get; set; }

        /// <summary>
        /// If createOption is ImportSecure, this is the URI of a blob to be imported into VM guest state.
        /// </summary>
        [JsonPropertyName("securityDataUri")]
        public string SecurityDataUri { get; set; }

        /// <summary>
        /// If createOption is Copy, this is the ARM id of the source snapshot or disk.
        /// </summary>
        [JsonPropertyName("sourceResourceId")]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// If createOption is Import, this is the URI of a blob to be imported into a managed disk.
        /// </summary>
        [JsonPropertyName("sourceUri")]
        public string SourceUri { get; set; }

        /// <summary>
        /// Required if createOption is Import. The Azure Resource Manager identifier of the storage account containing the blob to import as a disk.
        /// </summary>
        [JsonPropertyName("storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// If createOption is Upload, this is the size of the contents of the upload including the VHD footer. This value should be between 20972032 (20 MiB + 512 bytes for the VHD footer) and 35183298347520 bytes (32 TiB + 512 bytes for the VHD footer).
        /// </summary>
        [JsonPropertyName("uploadSizeBytes")]
        public int UploadSizeBytes { get; set; }
    }
}