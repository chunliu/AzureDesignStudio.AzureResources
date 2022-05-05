// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The GitHub action configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GitHubActionConfiguration
    {
        /// <summary>
        /// The GitHub action code configuration.
        /// </summary>
        [JsonPropertyName("codeConfiguration")]
        public GitHubActionCodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// The GitHub action container configuration.
        /// </summary>
        [JsonPropertyName("containerConfiguration")]
        public GitHubActionContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// Workflow option to determine whether the workflow file should be generated and written to the repository.
        /// </summary>
        [JsonPropertyName("generateWorkflowFile")]
        public bool GenerateWorkflowFile { get; set; }

        /// <summary>
        /// This will help determine the workflow configuration to select.
        /// </summary>
        [JsonPropertyName("isLinux")]
        public bool IsLinux { get; set; }
    }
}