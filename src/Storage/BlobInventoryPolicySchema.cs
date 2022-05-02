using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The storage account blob inventory policy rules.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BlobInventoryPolicySchema
    {
        /// <summary>
        /// Policy is enabled if set to true.
        /// </summary>
        [Required]
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The storage account blob inventory policy rules. The rule is applied when it is enabled.
        /// </summary>
        [Required]
        [JsonPropertyName("rules")]
        public IList<BlobInventoryPolicyRule> Rules { get; set; }

        /// <summary>
        /// The valid value is Inventory
        /// </summary>
        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}