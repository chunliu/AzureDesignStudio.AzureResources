// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Partner server information for the failover group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PartnerInfo
    {
        /// <summary>
        /// Resource identifier of the partner server.
        /// </summary>
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}