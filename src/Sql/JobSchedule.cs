using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Scheduling properties of a job.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JobSchedule
    {
        /// <summary>
        /// Whether or not the schedule is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Schedule end time.
        /// </summary>
        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Value of the schedule's recurring interval, if the ScheduleType is recurring. ISO8601 duration format.
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Schedule start time.
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Schedule interval type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}