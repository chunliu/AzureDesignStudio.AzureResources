using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// SKU of Firewall policy.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicySku
    {
        /// <summary>
        /// Tier of Firewall Policy.
        /// </summary>
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
    }
}