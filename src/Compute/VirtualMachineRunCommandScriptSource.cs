// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the script sources for run command.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineRunCommandScriptSource
    {
        /// <summary>
        /// Specifies a commandId of predefined built-in script.
        /// </summary>
        [JsonPropertyName("commandId")]
        public string CommandId { get; set; }

        /// <summary>
        /// Specifies the script content to be executed on the VM.
        /// </summary>
        [JsonPropertyName("script")]
        public string Script { get; set; }

        /// <summary>
        /// Specifies the script download location.
        /// </summary>
        [JsonPropertyName("scriptUri")]
        public string ScriptUri { get; set; }
    }
}