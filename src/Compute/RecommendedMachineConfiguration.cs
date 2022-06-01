// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The properties describe the recommended machine configuration for this Image Definition. These properties are updatable.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RecommendedMachineConfiguration
    {
        /// <summary>
        /// Describes the resource range.
        /// </summary>
        [JsonPropertyName("memory")]
        public ResourceRange Memory { get; set; }

        /// <summary>
        /// Describes the resource range.
        /// </summary>
        [JsonPropertyName("vCPUs")]
        public ResourceRange VCPUs { get; set; }
    }
}