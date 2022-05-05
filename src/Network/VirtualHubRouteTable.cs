// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VirtualHub route table.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualHubRouteTable
    {
        /// <summary>
        /// List of all routes.
        /// </summary>
        [JsonPropertyName("routes")]
        public IList<VirtualHubRoute> Routes { get; set; }
    }
}