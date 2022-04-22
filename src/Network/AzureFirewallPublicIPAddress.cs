using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Public IP Address associated with azure firewall.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureFirewallPublicIPAddress
    {
        /// <summary>
        /// Public IP Address value.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}