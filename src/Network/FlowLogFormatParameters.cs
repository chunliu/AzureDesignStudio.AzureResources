using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters that define the flow log format.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FlowLogFormatParameters
    {
        /// <summary>
        /// The file type of flow log.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The version (revision) of the flow log.
        /// </summary>
        [JsonPropertyName("version")]
        public int Version { get; set; }
    }
}