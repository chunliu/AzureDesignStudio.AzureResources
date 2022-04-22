using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// SKU of an Azure Firewall.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureFirewallSku
    {
        /// <summary>
        /// Name of an Azure Firewall SKU.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tier of an Azure Firewall.
        /// </summary>
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
    }
}