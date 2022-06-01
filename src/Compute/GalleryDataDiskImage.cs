// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// This is the data disk image.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryDataDiskImage
    {
        /// <summary>
        /// The host caching of the disk. Valid values are 'None', 'ReadOnly', and 'ReadWrite'.
        /// </summary>
        [JsonPropertyName("hostCaching")]
        public string HostCaching { get; set; }

        /// <summary>
        /// This property specifies the logical unit number of the data disk. This value is used to identify data disks within the Virtual Machine and therefore must be unique for each data disk attached to the Virtual Machine.
        /// </summary>
        [Required]
        [JsonPropertyName("lun")]
        public int Lun { get; set; }

        /// <summary>
        /// The gallery artifact version source.
        /// </summary>
        [JsonPropertyName("source")]
        public GalleryArtifactVersionSource Source { get; set; }
    }
}