using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the connection monitor endpoint scope.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorEndpointScope
    {
        /// <summary>
        /// List of items which needs to be included to the endpoint scope.
        /// </summary>
        [JsonPropertyName("include")]
        public IList<ConnectionMonitorEndpointScopeItem> Include { get; set; }

        /// <summary>
        /// List of items which needs to be excluded from the endpoint scope.
        /// </summary>
        [JsonPropertyName("exclude")]
        public IList<ConnectionMonitorEndpointScopeItem> Exclude { get; set; }
    }
}