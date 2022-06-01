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
    /// Microsoft.Compute/galleries/images
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleriesImages : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-07-01";

        /// <summary>
        /// Describes the properties of a gallery image definition.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public GalleryImageProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<GalleriesImagesVersions> Resources { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Compute/galleries/images";
    }
}