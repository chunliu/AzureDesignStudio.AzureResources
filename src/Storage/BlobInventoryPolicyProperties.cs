using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The storage account blob inventory policy properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BlobInventoryPolicyProperties
    {
        /// <summary>
        /// The storage account blob inventory policy rules.
        /// </summary>
        [Required]
        [JsonPropertyName("policy")]
        public BlobInventoryPolicySchema Policy { get; set; }
    }
}