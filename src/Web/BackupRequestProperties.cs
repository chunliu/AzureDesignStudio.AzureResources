using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// BackupRequest resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BackupRequestProperties
    {
        /// <summary>
        /// Name of the backup.
        /// </summary>
        [JsonPropertyName("backupName")]
        public string BackupName { get; set; }

        /// <summary>
        /// Description of a backup schedule. Describes how often should be the backup performed and what should be the retention policy.
        /// </summary>
        [JsonPropertyName("backupSchedule")]
        public BackupSchedule BackupSchedule { get; set; }

        /// <summary>
        /// Databases included in the backup.
        /// </summary>
        [JsonPropertyName("databases")]
        public IList<DatabaseBackupSetting> Databases { get; set; }

        /// <summary>
        /// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// SAS URL to the container.
        /// </summary>
        [Required]
        [JsonPropertyName("storageAccountUrl")]
        public string StorageAccountUrl { get; set; }
    }
}