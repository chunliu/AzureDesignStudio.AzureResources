using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a job step.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JobStepProperties
    {
        /// <summary>
        /// The action to be executed by a job step.
        /// </summary>
        [Required]
        [JsonPropertyName("action")]
        public JobStepAction Action { get; set; }

        /// <summary>
        /// The resource ID of the job credential that will be used to connect to the targets.
        /// </summary>
        [Required]
        [JsonPropertyName("credential")]
        public string Credential { get; set; }

        /// <summary>
        /// The execution options of a job step.
        /// </summary>
        [JsonPropertyName("executionOptions")]
        public JobStepExecutionOptions ExecutionOptions { get; set; }

        /// <summary>
        /// The output configuration of a job step.
        /// </summary>
        [JsonPropertyName("output")]
        public JobStepOutput Output { get; set; }

        /// <summary>
        /// The job step's index within the job. If not specified when creating the job step, it will be created as the last step. If not specified when updating the job step, the step id is not modified.
        /// </summary>
        [JsonPropertyName("stepId")]
        public int StepId { get; set; }

        /// <summary>
        /// The resource ID of the target group that the job step will be executed on.
        /// </summary>
        [Required]
        [JsonPropertyName("targetGroup")]
        public string TargetGroup { get; set; }
    }
}