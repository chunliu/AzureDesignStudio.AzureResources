using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a database blob auditing policy.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class DatabaseBlobAuditingPolicyProperties
    {
        /// <summary>
        /// Specifies the Actions-Groups and Actions to audit.

        [JsonPropertyName("auditActionsAndGroups")]
        public IList<string> AuditActionsAndGroups { get; set; }

        /// <summary>
        /// Specifies whether audit events are sent to Azure Monitor. 
        [JsonPropertyName("isAzureMonitorTargetEnabled")]
        public bool IsAzureMonitorTargetEnabled { get; set; }

        /// <summary>
        /// Specifies whether storageAccountAccessKey value is the storage's secondary key.
        /// </summary>
        [JsonPropertyName("isStorageSecondaryKeyInUse")]
        public bool IsStorageSecondaryKeyInUse { get; set; }

        /// <summary>
        /// Specifies the amount of time in milliseconds that can elapse before audit actions are forced to be processed.
        [JsonPropertyName("queueDelayMs")]
        public int QueueDelayMs { get; set; }

        /// <summary>
        /// Specifies the number of days to keep in the audit logs in the storage account.
        /// </summary>
        [JsonPropertyName("retentionDays")]
        public int RetentionDays { get; set; }

        /// <summary>
        /// Specifies the state of the audit. If state is Enabled, storageEndpoint or isAzureMonitorTargetEnabled are required.
        /// </summary>
        [Required]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Specifies the identifier key of the auditing storage account. 
        [JsonPropertyName("storageAccountAccessKey")]
        public string StorageAccountAccessKey { get; set; }

        /// <summary>
        /// Specifies the blob storage subscription Id.
        /// </summary>
        [JsonPropertyName("storageAccountSubscriptionId")]
        public string StorageAccountSubscriptionId { get; set; }

        /// <summary>
        /// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). If state is Enabled, storageEndpoint or isAzureMonitorTargetEnabled is required.
        /// </summary>
        [JsonPropertyName("storageEndpoint")]
        public string StorageEndpoint { get; set; }
    }
}