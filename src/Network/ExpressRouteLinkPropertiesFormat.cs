// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties specific to ExpressRouteLink resources.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteLinkPropertiesFormat
    {
        /// <summary>
        /// Administrative state of the physical port.
        /// </summary>
        [JsonPropertyName("adminState")]
        public string AdminState { get; set; }

        /// <summary>
        /// MacSec configuration.
        /// </summary>
        [JsonPropertyName("macSecConfig")]
        public ExpressRouteLinkMacSecConfig MacSecConfig { get; set; }
    }
}