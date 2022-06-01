// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a Virtual Machine run command.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineRunCommandProperties
    {
        /// <summary>
        /// Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
        /// </summary>
        [JsonPropertyName("asyncExecution")]
        public bool AsyncExecution { get; set; }

        /// <summary>
        /// Specifies the Azure storage blob where script error stream will be uploaded.
        /// </summary>
        [JsonPropertyName("errorBlobUri")]
        public string ErrorBlobUri { get; set; }

        /// <summary>
        /// Specifies the Azure storage blob where script output stream will be uploaded.
        /// </summary>
        [JsonPropertyName("outputBlobUri")]
        public string OutputBlobUri { get; set; }

        /// <summary>
        /// The parameters used by the script.
        /// </summary>
        [JsonPropertyName("parameters")]
        public IList<RunCommandInputParameter> Parameters { get; set; }

        /// <summary>
        /// The parameters used by the script.
        /// </summary>
        [JsonPropertyName("protectedParameters")]
        public IList<RunCommandInputParameter> ProtectedParameters { get; set; }

        /// <summary>
        /// Specifies the user account password on the VM when executing the run command.
        /// </summary>
        [JsonPropertyName("runAsPassword")]
        public string RunAsPassword { get; set; }

        /// <summary>
        /// Specifies the user account on the VM when executing the run command.
        /// </summary>
        [JsonPropertyName("runAsUser")]
        public string RunAsUser { get; set; }

        /// <summary>
        /// Describes the script sources for run command.
        /// </summary>
        [JsonPropertyName("source")]
        public VirtualMachineRunCommandScriptSource Source { get; set; }

        /// <summary>
        /// The timeout in seconds to execute the run command.
        /// </summary>
        [JsonPropertyName("timeoutInSeconds")]
        public int TimeoutInSeconds { get; set; }
    }
}