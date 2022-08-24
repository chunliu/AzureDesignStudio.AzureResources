// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Full view of networking configuration for an ASE.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AseV3NetworkingConfiguration
    {
        /// <summary>
        /// Kind of resource.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// AseV3NetworkingConfiguration resource specific properties
        /// </summary>
        [JsonPropertyName("properties")]
        public AseV3NetworkingConfigurationProperties Properties { get; set; }
    }
}