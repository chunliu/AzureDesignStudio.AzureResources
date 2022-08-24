// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App scaling configurations.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Scale
    {
        /// <summary>
        /// Optional. Maximum number of container replicas. Defaults to 10 if not set.
        /// </summary>
        [JsonPropertyName("maxReplicas")]
        public int MaxReplicas { get; set; }

        /// <summary>
        /// Optional. Minimum number of container replicas.
        /// </summary>
        [JsonPropertyName("minReplicas")]
        public int MinReplicas { get; set; }

        /// <summary>
        /// Scaling rules.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<ScaleRule> Rules { get; set; }
    }
}