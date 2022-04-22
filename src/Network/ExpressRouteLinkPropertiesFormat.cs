using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties specific to ExpressRouteLink resources.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteLinkPropertiesFormat
    {
        /// <summary>
        /// Administrative state of the physical port.
        /// </summary>
        [JsonPropertyName("adminState")]
        public string AdminState { get; set; }

        /// <summary>
        /// MacSec configuration.
        /// </summary>
        [JsonPropertyName("macSecConfig")]
        public ExpressRouteLinkMacSecConfig MacSecConfig { get; set; }
    }
}