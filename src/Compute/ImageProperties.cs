// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of an Image.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ImageProperties
    {
        /// <summary>
        /// Specifies the HyperVGenerationType of the VirtualMachine created from the image. From API Version 2019-03-01 if the image source is a blob, then we need the user to specify the value, if the source is managed resource like disk or snapshot, we may require the user to specify the property if we cannot deduce it from the source managed resource.
        /// </summary>
        [JsonPropertyName("hyperVGeneration")]
        public string HyperVGeneration { get; set; }
        [JsonPropertyName("sourceVirtualMachine")]
        public SubResource SourceVirtualMachine { get; set; }

        /// <summary>
        /// Describes a storage profile.
        /// </summary>
        [JsonPropertyName("storageProfile")]
        public ImageStorageProfile StorageProfile { get; set; }
    }
}