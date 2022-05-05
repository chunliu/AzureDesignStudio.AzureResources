// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Metric limits set on an app.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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