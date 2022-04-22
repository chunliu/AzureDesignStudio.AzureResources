using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// SKU of a public IP prefix.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PublicIPPrefixSku
    {
        /// <summary>
        /// Name of a public IP prefix SKU.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tier of a public IP prefix SKU.
        /// </summary>
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
    }
}