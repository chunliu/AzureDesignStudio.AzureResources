// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// ContainerApp resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ContainerAppProperties
    {
        /// <summary>
        /// Non versioned Container App configuration properties that define the mutable settings of a Container app
        /// </summary>
        [JsonPropertyName("configuration")]
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Resource ID of the Container App's KubeEnvironment.
        /// </summary>
        [JsonPropertyName("kubeEnvironmentId")]
        public string KubeEnvironmentId { get; set; }

        /// <summary>
        /// Container App versioned application definition.
        [JsonPropertyName("template")]
        public Template Template { get; set; }
    }
}