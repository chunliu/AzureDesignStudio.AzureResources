using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// DSCP Configuration properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class DscpConfigurationPropertiesFormat
    {
        /// <summary>
        /// List of markings to be used in the configuration.
        /// </summary>
        [JsonPropertyName("markings")]
        public IList<int> Markings { get; set; }

        /// <summary>
        /// Source IP ranges.
        /// </summary>
        [JsonPropertyName("sourceIpRanges")]
        public IList<QosIpRange> SourceIpRanges { get; set; }

        /// <summary>
        /// Destination IP ranges.
        /// </summary>
        [JsonPropertyName("destinationIpRanges")]
        public IList<QosIpRange> DestinationIpRanges { get; set; }

        /// <summary>
        /// Sources port ranges.
        /// </summary>
        [JsonPropertyName("sourcePortRanges")]
        public IList<QosPortRange> SourcePortRanges { get; set; }

        /// <summary>
        /// Destination port ranges.
        /// </summary>
        [JsonPropertyName("destinationPortRanges")]
        public IList<QosPortRange> DestinationPortRanges { get; set; }

        /// <summary>
        /// RNM supported protocol types.
        /// </summary>
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }
    }
}