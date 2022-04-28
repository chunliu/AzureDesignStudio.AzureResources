using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Maintenance window time range.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class MaintenanceWindowTimeRange
    {
        /// <summary>
        /// Day of maintenance window.
        /// </summary>
        [JsonPropertyName("dayOfWeek")]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Duration of maintenance window in minutes.
        /// </summary>
        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Start time minutes offset from 12am.
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }
    }
}