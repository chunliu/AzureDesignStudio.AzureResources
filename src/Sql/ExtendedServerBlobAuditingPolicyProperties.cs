// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of an extended server blob auditing policy.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExtendedServerBlobAuditingPolicyProperties
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
        /// Specifies the state of devops audit. If state is Enabled, devops logs will be sent to Azure Monitor.
        [JsonPropertyName("isDevopsAuditEnabled")]
        public bool IsDevopsAuditEnabled { get; set; }

        /// <summary>
        /// Specifies whether storageAccountAccessKey value is the storage's secondary key.
        /// </summary>
        [JsonPropertyName("isStorageSecondaryKeyInUse")]
        public bool IsStorageSecondaryKeyInUse { get; set; }

        /// <summary>
        /// Specifies condition of where clause when creating an audit.
        /// </summary>
        [JsonPropertyName("predicateExpression")]
        public string PredicateExpression { get; set; }

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