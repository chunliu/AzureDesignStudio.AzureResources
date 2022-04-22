using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the connection monitor endpoint filter.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorEndpointFilter
    {
        /// <summary>
        /// The behavior of the endpoint filter. Currently only 'Include' is supported.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// List of items in the filter.
        /// </summary>
        [JsonPropertyName("items")]
        public IList<ConnectionMonitorEndpointFilterItem> Items { get; set; }
    }
}