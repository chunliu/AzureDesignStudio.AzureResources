using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// List of routes that control routing from VirtualHub into a virtual network connection.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VnetRoute
    {
        /// <summary>
        /// List of all Static Routes.
        /// </summary>
        [JsonPropertyName("staticRoutes")]
        public IList<StaticRoute> StaticRoutes { get; set; }
    }
}