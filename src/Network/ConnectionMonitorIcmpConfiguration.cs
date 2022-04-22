using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the ICMP configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorIcmpConfiguration
    {
        /// <summary>
        /// Value indicating whether path evaluation with trace route should be disabled.
        /// </summary>
        [JsonPropertyName("disableTraceRoute")]
        public bool DisableTraceRoute { get; set; }
    }
}