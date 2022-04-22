using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters that define the retention policy for flow log.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class RetentionPolicyParameters
    {
        /// <summary>
        /// Number of days to retain flow log records.
        /// </summary>
        [JsonPropertyName("days")]
        public int Days { get; set; }

        /// <summary>
        /// Flag to enable/disable retention.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}