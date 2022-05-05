// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Workload classifier definition. For more information look at sys.workload_management_workload_classifiers (DMV).
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class WorkloadClassifierProperties
    {
        /// <summary>
        /// The workload classifier context.
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// The workload classifier end time for classification.
        /// </summary>
        [JsonPropertyName("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// The workload classifier importance.
        /// </summary>
        [JsonPropertyName("importance")]
        public string Importance { get; set; }

        /// <summary>
        /// The workload classifier label.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// The workload classifier member name.
        /// </summary>
        [Required]
        [JsonPropertyName("memberName")]
        public string MemberName { get; set; }

        /// <summary>
        /// The workload classifier start time for classification.
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }
    }
}