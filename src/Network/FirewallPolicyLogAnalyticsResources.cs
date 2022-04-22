using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Log Analytics Resources for Firewall Policy Insights.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicyLogAnalyticsResources
    {
        /// <summary>
        /// List of workspaces for Firewall Policy Insights.
        /// </summary>
        [JsonPropertyName("workspaces")]
        public IList<FirewallPolicyLogAnalyticsWorkspace> Workspaces { get; set; }

        /// <summary>
        /// The default workspace Id for Firewall Policy Insights.
        /// </summary>
        [JsonPropertyName("defaultWorkspaceId")]
        public SubResource DefaultWorkspaceId { get; set; }
    }
}