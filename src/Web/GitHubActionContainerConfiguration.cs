using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The GitHub action container configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class GitHubActionContainerConfiguration
    {
        /// <summary>
        /// The image name for the build.
        /// </summary>
        [JsonPropertyName("imageName")]
        public string ImageName { get; set; }

        /// <summary>
        /// The password used to upload the image to the container registry.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// The server URL for the container registry where the build will be hosted.
        /// </summary>
        [JsonPropertyName("serverUrl")]
        public string ServerUrl { get; set; }

        /// <summary>
        /// The username used to upload the image to the container registry.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
    }
}