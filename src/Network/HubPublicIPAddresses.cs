using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Public IP addresses associated with azure firewall.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HubPublicIPAddresses
    {
        /// <summary>
        /// The list of Public IP addresses associated with azure firewall or IP addresses to be retained.
        /// </summary>
        [JsonPropertyName("addresses")]
        public IList<AzureFirewallPublicIPAddress> Addresses { get; set; }

        /// <summary>
        /// The number of Public IP addresses associated with azure firewall.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}