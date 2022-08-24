// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Traffic weight assigned to a revision
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TrafficWeight
    {
        /// <summary>
        /// Indicates that the traffic weight belongs to a latest stable revision
        /// </summary>
        [JsonPropertyName("latestRevision")]
        public bool LatestRevision { get; set; }

        /// <summary>
        /// Name of a revision
        /// </summary>
        [JsonPropertyName("revisionName")]
        public string RevisionName { get; set; }

        /// <summary>
        /// Traffic weight assigned to a revision
        /// </summary>
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
    }
}