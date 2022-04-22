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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class RouteFilterPropertiesFormat
    {
        /// <summary>
        /// Collection of RouteFilterRules contained within a route filter.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<RouteFilterRule> Rules { get; set; }
    }
}