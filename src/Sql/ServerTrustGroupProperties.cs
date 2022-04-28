using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a server trust group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServerTrustGroupProperties
    {
        /// <summary>
        /// Group members information for the server trust group.
        /// </summary>
        [Required]
        [JsonPropertyName("groupMembers")]
        public IList<ServerInfo> GroupMembers { get; set; }

        /// <summary>
        /// Trust scope of the server trust group.
        /// </summary>
        [Required]
        [JsonPropertyName("trustScopes")]
        public IList<string> TrustScopes { get; set; }
    }
}