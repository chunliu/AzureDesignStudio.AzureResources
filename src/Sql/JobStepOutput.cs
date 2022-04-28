using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The output configuration of a job step.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JobStepOutput
    {
        /// <summary>
        /// The resource ID of the credential to use to connect to the output destination.
        /// </summary>
        [Required]
        [JsonPropertyName("credential")]
        public string Credential { get; set; }

        /// <summary>
        /// The output destination database.
        /// </summary>
        [Required]
        [JsonPropertyName("databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The output destination resource group.
        /// </summary>
        [JsonPropertyName("resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The output destination schema.
        /// </summary>
        [JsonPropertyName("schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// The output destination server name.
        /// </summary>
        [Required]
        [JsonPropertyName("serverName")]
        public string ServerName { get; set; }

        /// <summary>
        /// The output destination subscription id.
        /// </summary>
        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The output destination table.
        /// </summary>
        [Required]
        [JsonPropertyName("tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// The output destination type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}