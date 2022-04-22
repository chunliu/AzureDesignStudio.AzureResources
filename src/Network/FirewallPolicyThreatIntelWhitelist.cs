using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// ThreatIntel Whitelist for Firewall Policy.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicyThreatIntelWhitelist
    {
        /// <summary>
        /// List of IP addresses for the ThreatIntel Whitelist.
        /// </summary>
        [JsonPropertyName("ipAddresses")]
        public IList<string> IpAddresses { get; set; }

        /// <summary>
        /// List of FQDNs for the ThreatIntel Whitelist.
        /// </summary>
        [JsonPropertyName("fqdns")]
        public IList<string> Fqdns { get; set; }
    }
}