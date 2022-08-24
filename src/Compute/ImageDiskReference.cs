// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The source image used for creating the disk.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ImageDiskReference
    {
        /// <summary>
        /// A relative uri containing a community Azure Compute Gallery image reference.
        /// </summary>
        [JsonPropertyName("communityGalleryImageId")]
        public string CommunityGalleryImageId { get; set; }

        /// <summary>
        /// A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// If the disk is created from an image's data disk, this is an index that indicates which of the data disks in the image to use. For OS disks, this field is null.
        /// </summary>
        [JsonPropertyName("lun")]
        public int Lun { get; set; }

        /// <summary>
        /// A relative uri containing a direct shared Azure Compute Gallery image reference.
        /// </summary>
        [JsonPropertyName("sharedGalleryImageId")]
        public string SharedGalleryImageId { get; set; }
    }
}