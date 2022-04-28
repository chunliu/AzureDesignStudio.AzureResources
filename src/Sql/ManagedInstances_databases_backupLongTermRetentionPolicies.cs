using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/managedInstances/databases/backupLongTermRetentionPolicies
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedInstances_databases_backupLongTermRetentionPolicies : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01-preview";

        /// <summary>
        /// Properties of a long term retention policy
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public BaseLongTermRetentionPolicyProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/managedInstances/databases/backupLongTermRetentionPolicies";
    }
}