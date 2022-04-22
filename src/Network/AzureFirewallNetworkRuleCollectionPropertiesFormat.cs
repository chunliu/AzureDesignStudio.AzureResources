using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the network rule collection.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureFirewallNetworkRuleCollectionPropertiesFormat
    {
        /// <summary>
        /// Priority of the network rule collection resource.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// The action type of a rule collection.
        /// </summary>
        [JsonPropertyName("action")]
        public AzureFirewallRCAction Action { get; set; }

        /// <summary>
        /// Collection of rules used by a network rule collection.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<AzureFirewallNetworkRule> Rules { get; set; }
    }
}