using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters. 
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagementPolicyFilter
    {
        /// <summary>
        /// An array of blob index tag based filters, there can be at most 10 tag filters
        /// </summary>
        [JsonPropertyName("blobIndexMatch")]
        public IList<TagFilter> BlobIndexMatch { get; set; }

        /// <summary>
        /// An array of predefined enum values. Currently blockBlob supports all tiering and delete actions. Only delete actions are supported for appendBlob.
        /// </summary>
        [Required]
        [JsonPropertyName("blobTypes")]
        public IList<string> BlobTypes { get; set; }

        /// <summary>
        /// An array of strings for prefixes to be match.
        /// </summary>
        [JsonPropertyName("prefixMatch")]
        public IList<string> PrefixMatch { get; set; }
    }
}