// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Partner region information for the failover group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PartnerRegionInfo
    {
        /// <summary>
        /// Geo location of the partner managed instances.
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }
    }
}