using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The replication policy rule between two containers.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ObjectReplicationPolicyRule
    {
        /// <summary>
        /// Required. Destination container name.
        /// </summary>
        [Required]
        [JsonPropertyName("destinationContainer")]
        public string DestinationContainer { get; set; }

        /// <summary>
        /// Filters limit replication to a subset of blobs within the storage account. A logical OR is performed on values in the filter. If multiple filters are defined, a logical AND is performed on all filters.
        /// </summary>
        [JsonPropertyName("filters")]
        public ObjectReplicationPolicyFilter Filters { get; set; }

        /// <summary>
        /// Rule Id is auto-generated for each new rule on destination account. It is required for put policy on source account.
        /// </summary>
        [JsonPropertyName("ruleId")]
        public string RuleId { get; set; }

        /// <summary>
        /// Required. Source container name.
        /// </summary>
        [Required]
        [JsonPropertyName("sourceContainer")]
        public string SourceContainer { get; set; }
    }
}