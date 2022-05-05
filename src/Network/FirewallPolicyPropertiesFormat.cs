// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Firewall Policy definition.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FirewallPolicyPropertiesFormat
    {
        /// <summary>
        /// The parent firewall policy from which rules are inherited.
        /// </summary>
        [JsonPropertyName("basePolicy")]
        public SubResource BasePolicy { get; set; }

        /// <summary>
        /// The operation mode for Threat Intelligence.
        /// </summary>
        [JsonPropertyName("threatIntelMode")]
        public string ThreatIntelMode { get; set; }

        /// <summary>
        /// ThreatIntel Whitelist for Firewall Policy.
        /// </summary>
        [JsonPropertyName("threatIntelWhitelist")]
        public FirewallPolicyThreatIntelWhitelist ThreatIntelWhitelist { get; set; }

        /// <summary>
        /// Insights on Firewall Policy.
        /// </summary>
        [JsonPropertyName("insights")]
        public FirewallPolicyInsights Insights { get; set; }

        /// <summary>
        /// The private IP addresses/IP ranges to which traffic will not be SNAT.
        /// </summary>
        [JsonPropertyName("snat")]
        public FirewallPolicySNAT Snat { get; set; }

        /// <summary>
        /// DNS Proxy Settings definition.
        /// </summary>
        [JsonPropertyName("dnsSettings")]
        public DnsSettings DnsSettings { get; set; }

        /// <summary>
        /// The configuration for Intrusion detection.
        /// </summary>
        [JsonPropertyName("intrusionDetection")]
        public FirewallPolicyIntrusionDetection IntrusionDetection { get; set; }

        /// <summary>
        /// TLS Configuration definition.
        /// </summary>
        [JsonPropertyName("transportSecurity")]
        public FirewallPolicyTransportSecurity TransportSecurity { get; set; }

        /// <summary>
        /// The Firewall Policy SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public FirewallPolicySku Sku { get; set; }
    }
}