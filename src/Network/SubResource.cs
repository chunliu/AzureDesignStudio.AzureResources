using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Reference to another subresource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SubResource
    {
        /// <summary>
        /// Resource ID.
        /// </summary>
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}