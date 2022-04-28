using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Workload group definition. For more information look at sys.workload_management_workload_groups (DMV).
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class WorkloadGroupProperties
    {
        /// <summary>
        /// The workload group importance level.
        /// </summary>
        [JsonPropertyName("importance")]
        public string Importance { get; set; }

        /// <summary>
        /// The workload group cap percentage resource.
        /// </summary>
        [Required]
        [JsonPropertyName("maxResourcePercent")]
        public int MaxResourcePercent { get; set; }

        /// <summary>
        /// The workload group request maximum grant percentage.
        /// </summary>
        [JsonPropertyName("maxResourcePercentPerRequest")]
        public double MaxResourcePercentPerRequest { get; set; }

        /// <summary>
        /// The workload group minimum percentage resource.
        /// </summary>
        [Required]
        [JsonPropertyName("minResourcePercent")]
        public int MinResourcePercent { get; set; }

        /// <summary>
        /// The workload group request minimum grant percentage.
        /// </summary>
        [Required]
        [JsonPropertyName("minResourcePercentPerRequest")]
        public double MinResourcePercentPerRequest { get; set; }

        /// <summary>
        /// The workload group query execution timeout.
        /// </summary>
        [JsonPropertyName("queryExecutionTimeout")]
        public int QueryExecutionTimeout { get; set; }
    }
}