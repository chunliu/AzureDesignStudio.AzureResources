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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualHubRouteTable
    {
        /// <summary>
        /// List of all routes.
        /// </summary>
        [JsonPropertyName("routes")]
        public IList<VirtualHubRoute> Routes { get; set; }
    }
}