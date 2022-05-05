// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The properties of a storage account’s Blob service.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BlobServicePropertiesProperties
    {
        /// <summary>
        /// Deprecated in favor of isVersioningEnabled property.
        /// </summary>
        [JsonPropertyName("automaticSnapshotPolicyEnabled")]
        public bool AutomaticSnapshotPolicyEnabled { get; set; }

        /// <summary>
        /// The blob service properties for change feed events.
        /// </summary>
        [JsonPropertyName("changeFeed")]
        public ChangeFeed ChangeFeed { get; set; }

        /// <summary>
        /// The service properties for soft delete.
        /// </summary>
        [JsonPropertyName("containerDeleteRetentionPolicy")]
        public DeleteRetentionPolicy ContainerDeleteRetentionPolicy { get; set; }

        /// <summary>
        /// Sets the CORS rules. You can include up to five CorsRule elements in the request. 
        /// </summary>
        [JsonPropertyName("cors")]
        public CorsRules Cors { get; set; }

        /// <summary>
        /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
        /// </summary>
        [JsonPropertyName("defaultServiceVersion")]
        public string DefaultServiceVersion { get; set; }

        /// <summary>
        /// The service properties for soft delete.
        /// </summary>
        [JsonPropertyName("deleteRetentionPolicy")]
        public DeleteRetentionPolicy DeleteRetentionPolicy { get; set; }

        /// <summary>
        /// Versioning is enabled if set to true.
        /// </summary>
        [JsonPropertyName("isVersioningEnabled")]
        public bool IsVersioningEnabled { get; set; }

        /// <summary>
        /// The blob service properties for Last access time based tracking policy.
        /// </summary>
        [JsonPropertyName("lastAccessTimeTrackingPolicy")]
        public LastAccessTimeTrackingPolicy LastAccessTimeTrackingPolicy { get; set; }

        /// <summary>
        /// The blob service properties for blob restore policy
        /// </summary>
        [JsonPropertyName("restorePolicy")]
        public RestorePolicyProperties RestorePolicy { get; set; }
    }
}