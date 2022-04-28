using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedInstancePrivateLinkServiceConnectionStateProperty
    {
        /// <summary>
        /// The private link service connection description.
        /// </summary>
        [Required]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The private link service connection status.
        /// </summary>
        [Required]
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}