// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the destination of connection monitor.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ConnectionMonitorDestination
    {
        /// <summary>
        /// The ID of the resource used as the destination by connection monitor.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Address of the connection monitor destination (IP or domain name).
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// The destination port used by connection monitor.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }
    }
}