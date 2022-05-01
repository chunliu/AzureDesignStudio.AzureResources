using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Description of a backup schedule. Describes how often should be the backup performed and what should be the retention policy.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BackupSchedule
    {
        /// <summary>
        /// How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and FrequencyUnit should be set to Day)
        /// </summary>
        [Required]
        [JsonPropertyName("frequencyInterval")]
        public int FrequencyInterval { get; set; }

        /// <summary>
        /// The unit of time for how often the backup should be executed (e.g. for weekly backup, this should be set to Day and FrequencyInterval should be set to 7).
        /// </summary>
        [Required]
        [JsonPropertyName("frequencyUnit")]
        public string FrequencyUnit { get; set; }

        /// <summary>
        /// True if the retention policy should always keep at least one backup in the storage account, regardless how old it is; false otherwise.
        /// </summary>
        [Required]
        [JsonPropertyName("keepAtLeastOneBackup")]
        public bool KeepAtLeastOneBackup { get; set; }

        /// <summary>
        /// After how many days backups should be deleted.
        /// </summary>
        [Required]
        [JsonPropertyName("retentionPeriodInDays")]
        public int RetentionPeriodInDays { get; set; }

        /// <summary>
        /// When the schedule should start working.
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }
    }
}