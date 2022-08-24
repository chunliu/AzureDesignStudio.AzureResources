// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App versioned application definition.
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Template
    {
        /// <summary>
        /// List of container definitions for the Container App.
        /// </summary>
        [JsonPropertyName("containers")]
        public IList<Container> Containers { get; set; }

        /// <summary>
        /// Container App Dapr configuration.
        /// </summary>
        [JsonPropertyName("dapr")]
        public Dapr Dapr { get; set; }

        /// <summary>
        /// User friendly suffix that is appended to the revision name
        /// </summary>
        [JsonPropertyName("revisionSuffix")]
        public string RevisionSuffix { get; set; }

        /// <summary>
        /// Container App scaling configurations.
        /// </summary>
        [JsonPropertyName("scale")]
        public Scale Scale { get; set; }
    }
}