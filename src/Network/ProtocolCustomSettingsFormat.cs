using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// DDoS custom policy properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ProtocolCustomSettingsFormat
    {
        /// <summary>
        /// The protocol for which the DDoS protection policy is being customized.
        /// </summary>
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// The customized DDoS protection trigger rate.
        /// </summary>
        [JsonPropertyName("triggerRateOverride")]
        public string TriggerRateOverride { get; set; }

        /// <summary>
        /// The customized DDoS protection source rate.
        /// </summary>
        [JsonPropertyName("sourceRateOverride")]
        public string SourceRateOverride { get; set; }

        /// <summary>
        /// The customized DDoS protection trigger rate sensitivity degrees. High: Trigger rate set with most sensitivity w.r.t. normal traffic. Default: Trigger rate set with moderate sensitivity w.r.t. normal traffic. Low: Trigger rate set with less sensitivity w.r.t. normal traffic. Relaxed: Trigger rate set with least sensitivity w.r.t. normal traffic.
        /// </summary>
        [JsonPropertyName("triggerSensitivityOverride")]
        public string TriggerSensitivityOverride { get; set; }
    }
}