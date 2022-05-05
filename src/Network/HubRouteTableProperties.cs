// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for RouteTable.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class HubRouteTableProperties
    {
        /// <summary>
        /// List of all routes.
        /// </summary>
        [JsonPropertyName("routes")]
        public IList<HubRoute> Routes { get; set; }

        /// <summary>
        /// List of labels associated with this route table.
        /// </summary>
        [JsonPropertyName("labels")]
        public IList<string> Labels { get; set; }
    }
}