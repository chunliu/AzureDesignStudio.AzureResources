// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the load balancer.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoadBalancingRulePropertiesFormat
    {
        /// <summary>
        /// A reference to frontend IP addresses.
        /// </summary>
        [Required]
        [JsonPropertyName("frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend IPs.
        /// </summary>
        [JsonPropertyName("backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// The reference to the load balancer probe used by the load balancing rule.
        /// </summary>
        [JsonPropertyName("probe")]
        public SubResource Probe { get; set; }

        /// <summary>
        /// The reference to the transport protocol used by the load balancing rule.
        /// </summary>
        [Required]
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// The load distribution policy for this rule.
        /// </summary>
        [JsonPropertyName("loadDistribution")]
        public string LoadDistribution { get; set; }

        /// <summary>
        /// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 0 and 65534. Note that value 0 enables "Any Port".
        /// </summary>
        [Required]
        [JsonPropertyName("frontendPort")]
        public int FrontendPort { get; set; }

        /// <summary>
        /// The port used for internal connections on the endpoint. Acceptable values are between 0 and 65535. Note that value 0 enables "Any Port".
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

        /// <summary>
        /// Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the frontend of the load balancing rule.
        /// </summary>
        [JsonPropertyName("disableOutboundSnat")]
        public bool DisableOutboundSnat { get; set; }
    }
}