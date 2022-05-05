// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VnetRoute
    {
        /// <summary>
        /// List of all Static Routes.
        /// </summary>
        [JsonPropertyName("staticRoutes")]
        public IList<StaticRoute> StaticRoutes { get; set; }
    }
}