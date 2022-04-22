using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters that define the operation to create a connection monitor.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorParameters
    {
        /// <summary>
        /// Describes the source of connection monitor.
        /// </summary>
        [JsonPropertyName("source")]
        public ConnectionMonitorSource Source { get; set; }

        /// <summary>
        /// Describes the destination of connection monitor.
        /// </summary>
        [JsonPropertyName("destination")]
        public ConnectionMonitorDestination Destination { get; set; }

        /// <summary>
        /// Determines if the connection monitor will start automatically once created.
        /// </summary>
        [JsonPropertyName("autoStart")]
        public bool AutoStart { get; set; }

        /// <summary>
        /// Monitoring interval in seconds.
        /// </summary>
        [JsonPropertyName("monitoringIntervalInSeconds")]
        public int MonitoringIntervalInSeconds { get; set; }

        /// <summary>
        /// List of connection monitor endpoints.
        /// </summary>
        [JsonPropertyName("endpoints")]
        public IList<ConnectionMonitorEndpoint> Endpoints { get; set; }

        /// <summary>
        /// List of connection monitor test configurations.
        /// </summary>
        [JsonPropertyName("testConfigurations")]
        public IList<ConnectionMonitorTestConfiguration> TestConfigurations { get; set; }

        /// <summary>
        /// List of connection monitor test groups.
        /// </summary>
        [JsonPropertyName("testGroups")]
        public IList<ConnectionMonitorTestGroup> TestGroups { get; set; }

        /// <summary>
        /// List of connection monitor outputs.
        /// </summary>
        [JsonPropertyName("outputs")]
        public IList<ConnectionMonitorOutput> Outputs { get; set; }

        /// <summary>
        /// Optional notes to be associated with the connection monitor.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    }
}