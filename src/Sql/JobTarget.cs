using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// A job target, for example a specific database or a container of databases that is evaluated during job execution.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JobTarget
    {
        /// <summary>
        /// The target database name.
        /// </summary>
        [JsonPropertyName("databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The target elastic pool name.
        /// </summary>
        [JsonPropertyName("elasticPoolName")]
        public string ElasticPoolName { get; set; }

        /// <summary>
        /// Whether the target is included or excluded from the group.
        /// </summary>
        [JsonPropertyName("membershipType")]
        public string MembershipType { get; set; }

        /// <summary>
        /// The resource ID of the credential that is used during job execution to connect to the target and determine the list of databases inside the target.
        /// </summary>
        [JsonPropertyName("refreshCredential")]
        public string RefreshCredential { get; set; }

        /// <summary>
        /// The target server name.
        /// </summary>
        [JsonPropertyName("serverName")]
        public string ServerName { get; set; }

        /// <summary>
        /// The target shard map.
        /// </summary>
        [JsonPropertyName("shardMapName")]
        public string ShardMapName { get; set; }

        /// <summary>
        /// The target type.
        /// </summary>
        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}