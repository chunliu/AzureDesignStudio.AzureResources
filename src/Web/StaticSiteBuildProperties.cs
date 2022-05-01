using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Build properties for the static site.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class StaticSiteBuildProperties
    {
        /// <summary>
        /// A custom command to run during deployment of the Azure Functions API application.
        /// </summary>
        [JsonPropertyName("apiBuildCommand")]
        public string ApiBuildCommand { get; set; }

        /// <summary>
        /// The path to the api code within the repository.
        /// </summary>
        [JsonPropertyName("apiLocation")]
        public string ApiLocation { get; set; }

        /// <summary>
        /// Deprecated: The path of the app artifacts after building (deprecated in favor of OutputLocation)
        /// </summary>
        [JsonPropertyName("appArtifactLocation")]
        public string AppArtifactLocation { get; set; }

        /// <summary>
        /// A custom command to run during deployment of the static content application.
        /// </summary>
        [JsonPropertyName("appBuildCommand")]
        public string AppBuildCommand { get; set; }

        /// <summary>
        /// The path to the app code within the repository.
        /// </summary>
        [JsonPropertyName("appLocation")]
        public string AppLocation { get; set; }

        /// <summary>
        /// Github Action secret name override.
        /// </summary>
        [JsonPropertyName("githubActionSecretNameOverride")]
        public string GithubActionSecretNameOverride { get; set; }

        /// <summary>
        /// The output path of the app after building.
        /// </summary>
        [JsonPropertyName("outputLocation")]
        public string OutputLocation { get; set; }

        /// <summary>
        /// Skip Github Action workflow generation.
        /// </summary>
        [JsonPropertyName("skipGithubActionWorkflowGeneration")]
        public bool SkipGithubActionWorkflowGeneration { get; set; }
    }
}