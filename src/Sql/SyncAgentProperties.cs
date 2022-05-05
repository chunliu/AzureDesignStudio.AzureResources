// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of an Azure SQL Database sync agent.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SyncAgentProperties
    {
        /// <summary>
        /// ARM resource id of the sync database in the sync agent.
        /// </summary>
        [JsonPropertyName("syncDatabaseId")]
        public string SyncDatabaseId { get; set; }
    }
}