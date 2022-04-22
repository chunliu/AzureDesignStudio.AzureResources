using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Network Virtual Appliance Sku Properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualApplianceSkuProperties
    {
        /// <summary>
        /// Virtual Appliance Vendor.
        /// </summary>
        [JsonPropertyName("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Virtual Appliance Scale Unit.
        /// </summary>
        [JsonPropertyName("bundledScaleUnit")]
        public string BundledScaleUnit { get; set; }

        /// <summary>
        /// Virtual Appliance Version.
        /// </summary>
        [JsonPropertyName("marketPlaceVersion")]
        public string MarketPlaceVersion { get; set; }
    }
}