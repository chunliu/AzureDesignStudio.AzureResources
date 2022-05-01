using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Metric limits set on an app.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SiteLimits
    {
        /// <summary>
        /// Maximum allowed disk size usage in MB.
        /// </summary>
        [JsonPropertyName("maxDiskSizeInMb")]
        public int MaxDiskSizeInMb { get; set; }

        /// <summary>
        /// Maximum allowed memory usage in MB.
        /// </summary>
        [JsonPropertyName("maxMemoryInMb")]
        public int MaxMemoryInMb { get; set; }

        /// <summary>
        /// Maximum allowed CPU usage percentage.
        /// </summary>
        [JsonPropertyName("maxPercentageCpu")]
        public double MaxPercentageCpu { get; set; }
    }
}