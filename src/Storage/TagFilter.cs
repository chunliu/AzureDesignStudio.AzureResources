using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Blob index tag based filtering for blob objects
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class TagFilter
    {
        /// <summary>
        /// This is the filter tag name, it can have 1 - 128 characters
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported
        /// </summary>
        [Required]
        [JsonPropertyName("op")]
        public string Op { get; set; }

        /// <summary>
        /// This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters
        /// </summary>
        [Required]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}