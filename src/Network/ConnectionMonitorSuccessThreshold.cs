using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the threshold for declaring a test successful.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorSuccessThreshold
    {
        /// <summary>
        /// The maximum percentage of failed checks permitted for a test to evaluate as successful.
        /// </summary>
        [JsonPropertyName("checksFailedPercent")]
        public int ChecksFailedPercent { get; set; }

        /// <summary>
        /// The maximum round-trip time in milliseconds permitted for a test to evaluate as successful.
        /// </summary>
        [JsonPropertyName("roundTripTimeMs")]
        public double RoundTripTimeMs { get; set; }
    }
}