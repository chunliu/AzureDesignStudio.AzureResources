using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the AzureFirewallRCAction.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureFirewallRCAction
    {
        /// <summary>
        /// The type of action.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}