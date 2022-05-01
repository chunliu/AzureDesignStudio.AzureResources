using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// PremierAddOn resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PremierAddOnProperties
    {
        /// <summary>
        /// Premier add on Marketplace offer.
        /// </summary>
        [JsonPropertyName("marketplaceOffer")]
        public string MarketplaceOffer { get; set; }

        /// <summary>
        /// Premier add on Marketplace publisher.
        /// </summary>
        [JsonPropertyName("marketplacePublisher")]
        public string MarketplacePublisher { get; set; }

        /// <summary>
        /// Premier add on Product.
        /// </summary>
        [JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// Premier add on SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Premier add on Vendor.
        /// </summary>
        [JsonPropertyName("vendor")]
        public string Vendor { get; set; }
    }
}