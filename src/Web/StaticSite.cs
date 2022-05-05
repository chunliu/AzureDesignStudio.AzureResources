// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// A static site.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StaticSite
    {
        /// <summary>
        /// <code>false</code> if config file is locked for this static web app; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("allowConfigFileUpdates")]
        public bool AllowConfigFileUpdates { get; set; }

        /// <summary>
        /// The target branch in the repository.
        /// </summary>
        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Build properties for the static site.
        /// </summary>
        [JsonPropertyName("buildProperties")]
        public StaticSiteBuildProperties BuildProperties { get; set; }

        /// <summary>
        /// A user's github repository token. This is used to setup the Github Actions workflow file and API secrets.
        /// </summary>
        [JsonPropertyName("repositoryToken")]
        public string RepositoryToken { get; set; }

        /// <summary>
        /// URL for the repository of the static site.
        /// </summary>
        [JsonPropertyName("repositoryUrl")]
        public string RepositoryUrl { get; set; }

        /// <summary>
        /// State indicating whether staging environments are allowed or not allowed for a static web app.
        /// </summary>
        [JsonPropertyName("stagingEnvironmentPolicy")]
        public string StagingEnvironmentPolicy { get; set; }

        /// <summary>
        /// Template Options for the static site.
        /// </summary>
        [JsonPropertyName("templateProperties")]
        public StaticSiteTemplateOptions TemplateProperties { get; set; }
    }
}