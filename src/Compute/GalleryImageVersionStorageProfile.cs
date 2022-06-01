// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// This is the storage profile of a Gallery Image Version.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryImageVersionStorageProfile
    {
        /// <summary>
        /// A list of data disk images.
        /// </summary>
        [JsonPropertyName("dataDiskImages")]
        public IList<GalleryDataDiskImage> DataDiskImages { get; set; }

        /// <summary>
        /// This is the OS disk image.
        /// </summary>
        [JsonPropertyName("osDiskImage")]
        public GalleryOSDiskImage OsDiskImage { get; set; }

        /// <summary>
        /// The gallery artifact version source.
        /// </summary>
        [JsonPropertyName("source")]
        public GalleryArtifactVersionSource Source { get; set; }
    }
}