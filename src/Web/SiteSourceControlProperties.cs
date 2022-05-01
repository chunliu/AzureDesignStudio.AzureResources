using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// SiteSourceControl resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SiteSourceControlProperties
    {
        /// <summary>
        /// Name of branch to use for deployment.
        /// </summary>
        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// <code>true</code> to enable deployment rollback; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("deploymentRollbackEnabled")]
        public bool DeploymentRollbackEnabled { get; set; }

        /// <summary>
        /// The GitHub action configuration.
        /// </summary>
        [JsonPropertyName("gitHubActionConfiguration")]
        public GitHubActionConfiguration GitHubActionConfiguration { get; set; }

        /// <summary>
        /// <code>true</code> if this is deployed via GitHub action.
        /// </summary>
        [JsonPropertyName("isGitHubAction")]
        public bool IsGitHubAction { get; set; }

        /// <summary>
        /// <code>true</code> to limit to manual integration; <code>false</code> to enable continuous integration (which configures webhooks into online repos like GitHub).
        /// </summary>
        [JsonPropertyName("isManualIntegration")]
        public bool IsManualIntegration { get; set; }

        /// <summary>
        /// <code>true</code> for a Mercurial repository; <code>false</code> for a Git repository.
        /// </summary>
        [JsonPropertyName("isMercurial")]
        public bool IsMercurial { get; set; }

        /// <summary>
        /// Repository or source control URL.
        /// </summary>
        [JsonPropertyName("repoUrl")]
        public string RepoUrl { get; set; }
    }
}