// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App container resource requirements.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ContainerResources
    {
        /// <summary>
        /// Required CPU in cores, e.g. 0.5
        /// </summary>
        [JsonPropertyName("cpu")]
        public double Cpu { get; set; }

        /// <summary>
        /// Required memory, e.g. "250Mb"
        /// </summary>
        [JsonPropertyName("memory")]
        public string Memory { get; set; }
    }
}