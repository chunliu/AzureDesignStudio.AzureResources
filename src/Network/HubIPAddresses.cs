using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// IP addresses associated with azure firewall.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HubIPAddresses
    {
        /// <summary>
        /// Public IP addresses associated with azure firewall.
        /// </summary>
        [JsonPropertyName("publicIPs")]
        public HubPublicIPAddresses PublicIPs { get; set; }

        /// <summary>
        /// Private IP Address associated with azure firewall.
        /// </summary>
        [JsonPropertyName("privateIPAddress")]
        public string PrivateIPAddress { get; set; }
    }
}