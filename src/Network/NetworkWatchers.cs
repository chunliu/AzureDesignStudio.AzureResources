using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/networkWatchers
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NetworkWatchers : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/networkWatchers";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the network watcher.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public NetworkWatcherPropertiesFormat Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<NetworkWatchers_flowLogs> Resources { get; set; }
    }
}