// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Route Table resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RouteTablePropertiesFormat
    {
        /// <summary>
        /// Collection of routes contained within a route table.
        /// </summary>
        [JsonPropertyName("routes")]
        public IList<Route> Routes { get; set; }

        /// <summary>
        /// Whether to disable the routes learned by BGP on that route table. True means disable.
        /// </summary>
        [JsonPropertyName("disableBgpRoutePropagation")]
        public bool DisableBgpRoutePropagation { get; set; }
    }
}