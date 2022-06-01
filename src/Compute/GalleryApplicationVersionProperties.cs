// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a gallery image version.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryApplicationVersionProperties
    {
        /// <summary>
        /// The publishing profile of a gallery image version.
        /// </summary>
        [Required]
        [JsonPropertyName("publishingProfile")]
        public GalleryApplicationVersionPublishingProfile PublishingProfile { get; set; }
    }
}