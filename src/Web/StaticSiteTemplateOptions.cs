// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Template Options for the static site.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StaticSiteTemplateOptions
    {
        /// <summary>
        /// Description of the newly generated repository.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether or not the newly generated repository is a private repository. Defaults to false (i.e. public).
        /// </summary>
        [JsonPropertyName("isPrivate")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Owner of the newly generated repository.
        /// </summary>
        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Name of the newly generated repository.
        /// </summary>
        [JsonPropertyName("repositoryName")]
        public string RepositoryName { get; set; }

        /// <summary>
        /// URL of the template repository. The newly generated repository will be based on this one.
        /// </summary>
        [JsonPropertyName("templateRepositoryUrl")]
        public string TemplateRepositoryUrl { get; set; }
    }
}