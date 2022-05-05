// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the settings for producing output into a log analytics workspace.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ConnectionMonitorWorkspaceSettings
    {
        /// <summary>
        /// Log analytics workspace resource ID.
        /// </summary>
        [JsonPropertyName("workspaceResourceId")]
        public string WorkspaceResourceId { get; set; }
    }
}