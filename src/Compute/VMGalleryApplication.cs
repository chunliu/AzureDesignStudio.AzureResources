// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the required information to reference a compute gallery application version
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VMGalleryApplication
    {
        /// <summary>
        /// Optional, Specifies the uri to an azure blob that will replace the default configuration for the package if provided
        /// </summary>
        [JsonPropertyName("configurationReference")]
        public string ConfigurationReference { get; set; }

        /// <summary>
        /// Optional, Specifies the order in which the packages have to be installed
        /// </summary>
        [JsonPropertyName("order")]
        public int Order { get; set; }

        /// <summary>
        /// Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
        /// </summary>
        [Required]
        [JsonPropertyName("packageReferenceId")]
        public string PackageReferenceId { get; set; }

        /// <summary>
        /// Optional, Specifies a passthrough value for more generic context.
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }
    }
}