using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the connection monitor endpoint filter item.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorEndpointFilterItem
    {
        /// <summary>
        /// The type of item included in the filter. Currently only 'AgentAddress' is supported.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The address of the filter item.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}