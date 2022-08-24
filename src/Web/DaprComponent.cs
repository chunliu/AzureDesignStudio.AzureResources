// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Dapr component configuration
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DaprComponent
    {
        /// <summary>
        /// Component metadata
        /// </summary>
        [JsonPropertyName("metadata")]
        public IList<DaprMetadata> Metadata { get; set; }

        /// <summary>
        /// Component name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Component type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Component version
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}