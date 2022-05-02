using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Filters limit replication to a subset of blobs within the storage account. A logical OR is performed on values in the filter. If multiple filters are defined, a logical AND is performed on all filters.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ObjectReplicationPolicyFilter
    {
        /// <summary>
        /// Blobs created after the time will be replicated to the destination. It must be in datetime format 'yyyy-MM-ddTHH:mm:ssZ'. Example: 2020-02-19T16:05:00Z
        /// </summary>
        [JsonPropertyName("minCreationTime")]
        public string MinCreationTime { get; set; }

        /// <summary>
        /// Optional. Filters the results to replicate only blobs whose names begin with the specified prefix.
        /// </summary>
        [JsonPropertyName("prefixMatch")]
        public IList<string> PrefixMatch { get; set; }
    }
}