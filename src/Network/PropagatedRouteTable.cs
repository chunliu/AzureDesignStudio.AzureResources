// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The list of RouteTables to advertise the routes to.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PropagatedRouteTable
    {
        /// <summary>
        /// The list of labels.
        /// </summary>
        [JsonPropertyName("labels")]
        public IList<string> Labels { get; set; }

        /// <summary>
        /// The list of resource ids of all the RouteTables.
        /// </summary>
        [JsonPropertyName("ids")]
        public IList<SubResource> Ids { get; set; }
    }
}