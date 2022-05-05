// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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