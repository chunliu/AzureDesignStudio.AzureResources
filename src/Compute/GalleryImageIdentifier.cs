// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// This is the gallery image definition identifier.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryImageIdentifier
    {
        /// <summary>
        /// The name of the gallery image definition offer.
        /// </summary>
        [Required]
        [JsonPropertyName("offer")]
        public string Offer { get; set; }

        /// <summary>
        /// The name of the gallery image definition publisher.
        /// </summary>
        [Required]
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// The name of the gallery image definition SKU.
        /// </summary>
        [Required]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
    }
}