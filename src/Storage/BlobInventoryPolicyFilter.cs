// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// An object that defines the blob inventory rule filter conditions. For 'Blob' definition.objectType all filter properties are applicable, 'blobTypes' is required and others are optional. For 'Container' definition.objectType only prefixMatch is applicable and is optional.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BlobInventoryPolicyFilter
    {
        /// <summary>
        /// An array of predefined enum values. Valid values include blockBlob, appendBlob, pageBlob. Hns accounts does not support pageBlobs. This field is required when definition.objectType property is set to 'Blob'.
        /// </summary>
        [JsonPropertyName("blobTypes")]
        public IList<string> BlobTypes { get; set; }

        /// <summary>
        /// An array of strings with maximum 10 blob prefixes to be excluded from the inventory.
        /// </summary>
        [JsonPropertyName("excludePrefix")]
        public IList<string> ExcludePrefix { get; set; }

        /// <summary>
        /// Includes blob versions in blob inventory when value is set to true. The definition.schemaFields values 'VersionId and IsCurrentVersion' are required if this property is set to true, else they must be excluded.
        /// </summary>
        [JsonPropertyName("includeBlobVersions")]
        public bool IncludeBlobVersions { get; set; }

        /// <summary>
        /// For 'Container' definition.objectType the definition.schemaFields must include 'Deleted, Version, DeletedTime and RemainingRetentionDays'. For 'Blob' definition.objectType and HNS enabled storage accounts the definition.schemaFields must include 'DeletionId, Deleted, DeletedTime and RemainingRetentionDays' and for Hns disabled accounts the definition.schemaFields must include 'Deleted and RemainingRetentionDays', else it must be excluded.
        /// </summary>
        [JsonPropertyName("includeDeleted")]
        public bool IncludeDeleted { get; set; }

        /// <summary>
        /// Includes blob snapshots in blob inventory when value is set to true. The definition.schemaFields value 'Snapshot' is required if this property is set to true, else it must be excluded.
        /// </summary>
        [JsonPropertyName("includeSnapshots")]
        public bool IncludeSnapshots { get; set; }

        /// <summary>
        /// An array of strings with maximum 10 blob prefixes to be included in the inventory.
        /// </summary>
        [JsonPropertyName("prefixMatch")]
        public IList<string> PrefixMatch { get; set; }
    }
}