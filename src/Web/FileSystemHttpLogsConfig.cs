using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Http logs to file system configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FileSystemHttpLogsConfig
    {
        /// <summary>
        /// True if configuration is enabled, false if it is disabled and null if configuration is not set.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Retention in days.
        [JsonPropertyName("retentionInDays")]
        public int RetentionInDays { get; set; }

        /// <summary>
        /// Maximum size in megabytes that http log files can use.
        [JsonPropertyName("retentionInMb")]
        public int RetentionInMb { get; set; }
    }
}