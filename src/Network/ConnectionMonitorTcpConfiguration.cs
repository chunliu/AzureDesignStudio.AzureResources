// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the TCP configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ConnectionMonitorTcpConfiguration
    {
        /// <summary>
        /// The port to connect to.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }

        /// <summary>
        /// Value indicating whether path evaluation with trace route should be disabled.
        /// </summary>
        [JsonPropertyName("disableTraceRoute")]
        public bool DisableTraceRoute { get; set; }

        /// <summary>
        /// Destination port behavior.
        /// </summary>
        [JsonPropertyName("destinationPortBehavior")]
        public string DestinationPortBehavior { get; set; }
    }
}