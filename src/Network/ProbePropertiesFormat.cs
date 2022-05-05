// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Load balancer probe resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ProbePropertiesFormat
    {
        /// <summary>
        /// The protocol of the end point. If 'Tcp' is specified, a received ACK is required for the probe to be successful. If 'Http' or 'Https' is specified, a 200 OK response from the specifies URI is required for the probe to be successful.
        /// </summary>
        [Required]
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// The port for communicating the probe. Possible values range from 1 to 65535, inclusive.
        /// </summary>
        [Required]
        [JsonPropertyName("port")]
        public int Port { get; set; }

        /// <summary>
        /// The interval, in seconds, for how frequently to probe the endpoint for health status. Typically, the interval is slightly less than half the allocated timeout period (in seconds) which allows two full probes before taking the instance out of rotation. The default value is 15, the minimum value is 5.
        /// </summary>
        [JsonPropertyName("intervalInSeconds")]
        public int IntervalInSeconds { get; set; }

        /// <summary>
        /// The number of probes where if no response, will result in stopping further traffic from being delivered to the endpoint. This values allows endpoints to be taken out of rotation faster or slower than the typical times used in Azure.
        /// </summary>
        [Required]
        [JsonPropertyName("numberOfProbes")]
        public int NumberOfProbes { get; set; }

        /// <summary>
        /// The URI used for requesting health status from the VM. Path is required if a protocol is set to http. Otherwise, it is not allowed. There is no default value.
        /// </summary>
        [JsonPropertyName("requestPath")]
        public string RequestPath { get; set; }
    }
}