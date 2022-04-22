using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Contains stats associated with the peering.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteCircuitStats
    {
        /// <summary>
        /// The Primary BytesIn of the peering.
        /// </summary>
        [JsonPropertyName("primarybytesIn")]
        public int PrimarybytesIn { get; set; }

        /// <summary>
        /// The primary BytesOut of the peering.
        /// </summary>
        [JsonPropertyName("primarybytesOut")]
        public int PrimarybytesOut { get; set; }

        /// <summary>
        /// The secondary BytesIn of the peering.
        /// </summary>
        [JsonPropertyName("secondarybytesIn")]
        public int SecondarybytesIn { get; set; }

        /// <summary>
        /// The secondary BytesOut of the peering.
        /// </summary>
        [JsonPropertyName("secondarybytesOut")]
        public int SecondarybytesOut { get; set; }
    }
}