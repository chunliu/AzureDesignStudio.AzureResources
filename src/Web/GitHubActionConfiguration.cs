using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The GitHub action configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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