using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/servers/databases/workloadGroups
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServersDatabasesWorkloadGroups : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01-preview";

        /// <summary>
        /// Workload group definition. For more information look at sys.workload_management_workload_groups (DMV).
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public WorkloadGroupProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ServersDatabasesWorkloadGroupsWorkloadClassifiers> Resources { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/servers/databases/workloadGroups";
    }
}