using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a short term retention policy
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedBackupShortTermRetentionPolicyProperties
    {
        /// <summary>
        /// The backup retention period in days. This is how many days Point-in-Time Restore will be supported.
        /// </summary>
        [JsonPropertyName("retentionDays")]
        public int RetentionDays { get; set; }
    }
}