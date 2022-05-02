using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The Storage Account ObjectReplicationPolicy properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ObjectReplicationPolicyProperties
    {
        /// <summary>
        /// Required. Destination account name. It should be full resource id if allowCrossTenantReplication set to false.
        /// </summary>
        [Required]
        [JsonPropertyName("destinationAccount")]
        public string DestinationAccount { get; set; }

        /// <summary>
        /// The storage account object replication rules.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<ObjectReplicationPolicyRule> Rules { get; set; }

        /// <summary>
        /// Required. Source account name. It should be full resource id if allowCrossTenantReplication set to false.
        /// </summary>
        [Required]
        [JsonPropertyName("sourceAccount")]
        public string SourceAccount { get; set; }
    }
}