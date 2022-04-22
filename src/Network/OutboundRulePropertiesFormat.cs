using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Outbound rule of the load balancer.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class OutboundRulePropertiesFormat
    {
        /// <summary>
        /// The number of outbound ports to be used for NAT.
        /// </summary>
        [JsonPropertyName("allocatedOutboundPorts")]
        public int AllocatedOutboundPorts { get; set; }

        /// <summary>
        /// The Frontend IP addresses of the load balancer.
        /// </summary>
        [Required]
        [JsonPropertyName("frontendIPConfigurations")]
        public IList<SubResource> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend IPs.
        /// </summary>
        [Required]
        [JsonPropertyName("backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// The protocol for the outbound rule in load balancer.
        /// </summary>
        [Required]
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
        /// </summary>
        [JsonPropertyName("enableTcpReset")]
        public bool EnableTcpReset { get; set; }

        /// <summary>
        /// The timeout for the TCP idle connection.
        /// </summary>
        [JsonPropertyName("idleTimeoutInMinutes")]
        public int IdleTimeoutInMinutes { get; set; }
    }
}