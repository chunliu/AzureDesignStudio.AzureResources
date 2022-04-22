using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Firewall Policy Insights.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicyInsights
    {
        /// <summary>
        /// A flag to indicate if the insights are enabled on the policy.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Number of days the insights should be enabled on the policy.
        /// </summary>
        [JsonPropertyName("retentionDays")]
        public int RetentionDays { get; set; }

        /// <summary>
        /// Workspaces needed to configure the Firewall Policy Insights.
        /// </summary>
        [JsonPropertyName("logAnalyticsResources")]
        public FirewallPolicyLogAnalyticsResources LogAnalyticsResources { get; set; }
    }
}