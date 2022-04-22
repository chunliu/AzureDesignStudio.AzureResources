using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Network rule collection resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureFirewallNetworkRuleCollection
    {
        /// <summary>
        /// Properties of the azure firewall network rule collection.
        /// </summary>
        [JsonPropertyName("properties")]
        public AzureFirewallNetworkRuleCollectionPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within the Azure firewall. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}