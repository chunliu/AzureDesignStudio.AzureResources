using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Log Analytics Workspace for Firewall Policy Insights.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicyLogAnalyticsWorkspace
    {
        /// <summary>
        /// Region to configure the Workspace.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// The workspace Id for Firewall Policy Insights.
        /// </summary>
        [JsonPropertyName("workspaceId")]
        public SubResource WorkspaceId { get; set; }
    }
}