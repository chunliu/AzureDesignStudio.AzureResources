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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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