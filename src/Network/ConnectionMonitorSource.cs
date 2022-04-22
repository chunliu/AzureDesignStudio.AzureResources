using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the source of connection monitor.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorSource
    {
        /// <summary>
        /// The ID of the resource used as the source by connection monitor.
        /// </summary>
        [Required]
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// The source port used by connection monitor.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }
    }
}