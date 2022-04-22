using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the settings for producing output into a log analytics workspace.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorWorkspaceSettings
    {
        /// <summary>
        /// Log analytics workspace resource ID.
        /// </summary>
        [JsonPropertyName("workspaceResourceId")]
        public string WorkspaceResourceId { get; set; }
    }
}