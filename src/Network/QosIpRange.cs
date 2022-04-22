using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Qos Traffic Profiler IP Range properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class QosIpRange
    {
        /// <summary>
        /// Start IP Address.
        /// </summary>
        [JsonPropertyName("startIP")]
        public string StartIP { get; set; }

        /// <summary>
        /// End IP Address.
        /// </summary>
        [JsonPropertyName("endIP")]
        public string EndIP { get; set; }
    }
}