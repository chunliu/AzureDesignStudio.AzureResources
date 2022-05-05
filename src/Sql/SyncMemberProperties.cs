// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a sync member.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SyncMemberProperties
    {
        /// <summary>
        /// Database name of the member database in the sync member.
        /// </summary>
        [JsonPropertyName("databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Database type of the sync member.
        /// </summary>
        [JsonPropertyName("databaseType")]
        public string DatabaseType { get; set; }

        /// <summary>
        /// Password of the member database in the sync member.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Server name of the member database in the sync member
        /// </summary>
        [JsonPropertyName("serverName")]
        public string ServerName { get; set; }

        /// <summary>
        /// SQL Server database id of the sync member.
        /// </summary>
        [JsonPropertyName("sqlServerDatabaseId")]
        public string SqlServerDatabaseId { get; set; }

        /// <summary>
        /// ARM resource id of the sync agent in the sync member.
        /// </summary>
        [JsonPropertyName("syncAgentId")]
        public string SyncAgentId { get; set; }

        /// <summary>
        /// Sync direction of the sync member.
        /// </summary>
        [JsonPropertyName("syncDirection")]
        public string SyncDirection { get; set; }

        /// <summary>
        /// ARM resource id of the sync member logical database, for sync members in Azure.
        /// </summary>
        [JsonPropertyName("syncMemberAzureDatabaseResourceId")]
        public string SyncMemberAzureDatabaseResourceId { get; set; }

        /// <summary>
        /// Whether to use private link connection.
        /// </summary>
        [JsonPropertyName("usePrivateLinkConnection")]
        public bool UsePrivateLinkConnection { get; set; }

        /// <summary>
        /// User name of the member database in the sync member.
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    }
}