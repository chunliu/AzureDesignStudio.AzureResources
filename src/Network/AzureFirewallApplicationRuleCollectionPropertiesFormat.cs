using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the application rule collection.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureFirewallApplicationRuleCollectionPropertiesFormat
    {
        /// <summary>
        /// Priority of the application rule collection resource.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// The action type of a rule collection.
        /// </summary>
        [JsonPropertyName("action")]
        public AzureFirewallRCAction Action { get; set; }

        /// <summary>
        /// Collection of rules used by a application rule collection.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<AzureFirewallApplicationRule> Rules { get; set; }
    }
}