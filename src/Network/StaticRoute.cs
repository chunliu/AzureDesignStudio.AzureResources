// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// List of all Static Routes.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StaticRoute
    {
        /// <summary>
        /// The name of the StaticRoute that is unique within a VnetRoute.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// List of all address prefixes.
        /// </summary>
        [JsonPropertyName("addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }

        /// <summary>
        /// The ip address of the next hop.
        /// </summary>
        [JsonPropertyName("nextHopIpAddress")]
        public string NextHopIpAddress { get; set; }
    }
}