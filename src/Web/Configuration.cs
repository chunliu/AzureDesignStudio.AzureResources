// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Non versioned Container App configuration properties that define the mutable settings of a Container app
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Configuration
    {
        /// <summary>
        /// ActiveRevisionsMode controls how active revisions are handled for the Container app:
        [JsonPropertyName("activeRevisionsMode")]
        public string ActiveRevisionsMode { get; set; }

        /// <summary>
        /// Container App Ingress configuration.
        /// </summary>
        [JsonPropertyName("ingress")]
        public Ingress Ingress { get; set; }

        /// <summary>
        /// Collection of private container registry credentials for containers used by the Container app
        /// </summary>
        [JsonPropertyName("registries")]
        public IList<RegistryCredentials> Registries { get; set; }

        /// <summary>
        /// Collection of secrets used by a Container app
        /// </summary>
        [JsonPropertyName("secrets")]
        public IList<Secret> Secrets { get; set; }
    }
}