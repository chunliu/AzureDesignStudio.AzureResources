// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// This is the OS disk image.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryOSDiskImage
    {
        /// <summary>
        /// The host caching of the disk. Valid values are 'None', 'ReadOnly', and 'ReadWrite'.
        /// </summary>
        [JsonPropertyName("hostCaching")]
        public string HostCaching { get; set; }

        /// <summary>
        /// The gallery artifact version source.
        /// </summary>
        [JsonPropertyName("source")]
        public GalleryArtifactVersionSource Source { get; set; }
    }
}