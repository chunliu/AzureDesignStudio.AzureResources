using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Qos Traffic Profiler Port range properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class QosPortRange
    {
        /// <summary>
        /// Qos Port Range start.
        /// </summary>
        [JsonPropertyName("start")]
        public int Start { get; set; }

        /// <summary>
        /// Qos Port Range end.
        /// </summary>
        [JsonPropertyName("end")]
        public int End { get; set; }
    }
}