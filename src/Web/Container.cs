// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App container definition.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Container
    {
        /// <summary>
        /// Container start command arguments.
        /// </summary>
        [JsonPropertyName("args")]
        public IList<string> Args { get; set; }

        /// <summary>
        /// Container start command.
        /// </summary>
        [JsonPropertyName("command")]
        public IList<string> Command { get; set; }

        /// <summary>
        /// Container environment variables.
        /// </summary>
        [JsonPropertyName("env")]
        public IList<EnvironmentVar> Env { get; set; }

        /// <summary>
        /// Container image tag.
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// Custom container name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Container App container resource requirements.
        /// </summary>
        [JsonPropertyName("resources")]
        public ContainerResources Resources { get; set; }
    }
}