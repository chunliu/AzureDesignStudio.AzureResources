using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The SKU of the storage account.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Sku
    {
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
    }
}