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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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