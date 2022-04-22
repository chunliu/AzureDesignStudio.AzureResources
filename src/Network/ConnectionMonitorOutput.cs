using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes a connection monitor output destination.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorOutput
    {
        /// <summary>
        /// Connection monitor output destination type. Currently, only "Workspace" is supported.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Describes the settings for producing output into a log analytics workspace.
        /// </summary>
        [JsonPropertyName("workspaceSettings")]
        public ConnectionMonitorWorkspaceSettings WorkspaceSettings { get; set; }
    }
}