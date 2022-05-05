// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Route Filter Resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RouteFilterPropertiesFormat
    {
        /// <summary>
        /// Collection of RouteFilterRules contained within a route filter.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<RouteFilterRule> Rules { get; set; }
    }
}