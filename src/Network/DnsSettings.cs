using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// DNS Proxy Settings in Firewall Policy.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class DnsSettings
    {
        /// <summary>
        /// List of Custom DNS Servers.
        /// </summary>
        [JsonPropertyName("servers")]
        public IList<string> Servers { get; set; }

        /// <summary>
        /// Enable DNS Proxy on Firewalls attached to the Firewall Policy.
        /// </summary>
        [JsonPropertyName("enableProxy")]
        public bool EnableProxy { get; set; }

        /// <summary>
        /// FQDNs in Network Rules are supported when set to true.
        /// </summary>
        [JsonPropertyName("requireProxyForNetworkRules")]
        public bool RequireProxyForNetworkRules { get; set; }
    }
}