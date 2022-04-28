using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// An ARM Resource SKU.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Sku
    {
        /// <summary>
        /// Capacity of the particular SKU.
        /// </summary>
        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// If the service has different generations of hardware, for the same SKU, then that can be captured here.
        /// </summary>
        [JsonPropertyName("family")]
        public string Family { get; set; }

        /// <summary>
        /// The name of the SKU, typically, a letter + Number code, e.g. P3.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Size of the particular SKU
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; }

        /// <summary>
        /// The tier or edition of the particular SKU, e.g. Basic, Premium.
        /// </summary>
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
    }
}