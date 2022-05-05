// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The GitHub action code configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GitHubActionCodeConfiguration
    {
        /// <summary>
        /// Runtime stack is used to determine the workflow file content for code base apps.
        /// </summary>
        [JsonPropertyName("runtimeStack")]
        public string RuntimeStack { get; set; }

        /// <summary>
        /// Runtime version is used to determine what build version to set in the workflow file.
        /// </summary>
        [JsonPropertyName("runtimeVersion")]
        public string RuntimeVersion { get; set; }
    }
}