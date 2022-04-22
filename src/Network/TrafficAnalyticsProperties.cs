using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters that define the configuration of traffic analytics.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class TrafficAnalyticsProperties
    {
        /// <summary>
        /// Parameters that define the configuration of traffic analytics.
        /// </summary>
        [JsonPropertyName("networkWatcherFlowAnalyticsConfiguration")]
        public TrafficAnalyticsConfigurationProperties NetworkWatcherFlowAnalyticsConfiguration { get; set; }
    }
}