// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/servers/databases/syncGroups
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServersDatabasesSyncGroups : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01-preview";

        /// <summary>
        /// Properties of a sync group.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public SyncGroupProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ServersDatabasesSyncGroupsSyncMembers> Resources { get; set; }

        /// <summary>
        /// An ARM Resource SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public Sku Sku { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/servers/databases/syncGroups";
    }
}