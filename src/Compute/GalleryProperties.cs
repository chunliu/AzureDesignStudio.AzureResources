// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a Shared Image Gallery.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryProperties
    {
        /// <summary>
        /// The description of this Shared Image Gallery resource. This property is updatable.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Describes the gallery unique name.
        /// </summary>
        [JsonPropertyName("identifier")]
        public GalleryIdentifier Identifier { get; set; }

        /// <summary>
        /// Profile for gallery sharing to subscription or tenant
        /// </summary>
        [JsonPropertyName("sharingProfile")]
        public SharingProfile SharingProfile { get; set; }

        /// <summary>
        /// Contains information about the soft deletion policy of the gallery.
        /// </summary>
        [JsonPropertyName("softDeletePolicy")]
        public SoftDeletePolicy SoftDeletePolicy { get; set; }
    }
}