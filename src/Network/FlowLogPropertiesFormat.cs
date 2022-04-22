using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters that define the configuration of flow log.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FlowLogPropertiesFormat
    {
        /// <summary>
        /// ID of network security group to which flow log will be applied.
        /// </summary>
        [Required]
        [JsonPropertyName("targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// ID of the storage account which is used to store the flow log.
        /// </summary>
        [Required]
        [JsonPropertyName("storageId")]
        public string StorageId { get; set; }

        /// <summary>
        /// Flag to enable/disable flow logging.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Parameters that define the retention policy for flow log.
        /// </summary>
        [JsonPropertyName("retentionPolicy")]
        public RetentionPolicyParameters RetentionPolicy { get; set; }

        /// <summary>
        /// Parameters that define the flow log format.
        /// </summary>
        [JsonPropertyName("format")]
        public FlowLogFormatParameters Format { get; set; }

        /// <summary>
        /// Parameters that define the configuration of traffic analytics.
        /// </summary>
        [JsonPropertyName("flowAnalyticsConfiguration")]
        public TrafficAnalyticsProperties FlowAnalyticsConfiguration { get; set; }
    }
}