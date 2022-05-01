using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Rules that can be defined for auto-heal.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AutoHealRules
    {
        /// <summary>
        /// Actions which to take by the auto-heal module when a rule is triggered.
        /// </summary>
        [JsonPropertyName("actions")]
        public AutoHealActions Actions { get; set; }

        /// <summary>
        /// Triggers for auto-heal.
        /// </summary>
        [JsonPropertyName("triggers")]
        public AutoHealTriggers Triggers { get; set; }
    }
}