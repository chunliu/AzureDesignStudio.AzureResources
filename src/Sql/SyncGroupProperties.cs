// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a sync group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SyncGroupProperties
    {
        /// <summary>
        /// Conflict logging retention period.
        /// </summary>
        [JsonPropertyName("conflictLoggingRetentionInDays")]
        public int ConflictLoggingRetentionInDays { get; set; }

        /// <summary>
        /// Conflict resolution policy of the sync group.
        /// </summary>
        [JsonPropertyName("conflictResolutionPolicy")]
        public string ConflictResolutionPolicy { get; set; }

        /// <summary>
        /// If conflict logging is enabled.
        /// </summary>
        [JsonPropertyName("enableConflictLogging")]
        public bool EnableConflictLogging { get; set; }

        /// <summary>
        /// Password for the sync group hub database credential.
        /// </summary>
        [JsonPropertyName("hubDatabasePassword")]
        public string HubDatabasePassword { get; set; }

        /// <summary>
        /// User name for the sync group hub database credential.
        /// </summary>
        [JsonPropertyName("hubDatabaseUserName")]
        public string HubDatabaseUserName { get; set; }

        /// <summary>
        /// Sync interval of the sync group.
        /// </summary>
        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        /// <summary>
        /// Properties of sync group schema.
        /// </summary>
        [JsonPropertyName("schema")]
        public SyncGroupSchema Schema { get; set; }

        /// <summary>
        /// ARM resource id of the sync database in the sync group.
        /// </summary>
        [JsonPropertyName("syncDatabaseId")]
        public string SyncDatabaseId { get; set; }

        /// <summary>
        /// If use private link connection is enabled.
        /// </summary>
        [JsonPropertyName("usePrivateLinkConnection")]
        public bool UsePrivateLinkConnection { get; set; }
    }
}