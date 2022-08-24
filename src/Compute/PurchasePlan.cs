// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PurchasePlan
    {
        /// <summary>
        /// The plan ID.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        [Required]
        [JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// The Offer Promotion Code.
        /// </summary>
        [JsonPropertyName("promotionCode")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// The publisher ID.
        /// </summary>
        [Required]
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
    }
}