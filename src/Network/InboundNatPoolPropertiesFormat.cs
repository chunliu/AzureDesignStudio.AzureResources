// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of Inbound NAT pool.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class InboundNatPoolPropertiesFormat
    {
        /// <summary>
        /// A reference to frontend IP addresses.
        /// </summary>
        [Required]
        [JsonPropertyName("frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// The reference to the transport protocol used by the inbound NAT pool.
        /// </summary>
        [Required]
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// The first port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65534.
        /// </summary>
        [Required]
        [JsonPropertyName("frontendPortRangeStart")]
        public int FrontendPortRangeStart { get; set; }

        /// <summary>
        /// The last port number in the range of external ports that will be used to provide Inbound Nat to NICs associated with a load balancer. Acceptable values range between 1 and 65535.
        /// </summary>
        [Required]
        [JsonPropertyName("frontendPortRangeEnd")]
        public int FrontendPortRangeEnd { get; set; }

        /// <summary>
        /// The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.
        /// </summary>
        [Required]
        [JsonPropertyName("backendPort")]
        public int BackendPort { get; set; }

        /// <summary>
        /// The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP.
        /// </summary>
        [JsonPropertyName("idleTimeoutInMinutes")]
        public int IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Configures a virtual machine's endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can't be changed after you create the endpoint.
        /// </summary>
        [JsonPropertyName("enableFloatingIP")]
        public bool EnableFloatingIP { get; set; }

        /// <summary>
        /// Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
        /// </summary>
        [JsonPropertyName("enableTcpReset")]
        public bool EnableTcpReset { get; set; }
    }
}