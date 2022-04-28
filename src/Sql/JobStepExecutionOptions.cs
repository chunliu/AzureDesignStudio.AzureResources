using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The execution options of a job step.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JobStepExecutionOptions
    {
        /// <summary>
        /// Initial delay between retries for job step execution.
        /// </summary>
        [JsonPropertyName("initialRetryIntervalSeconds")]
        public int InitialRetryIntervalSeconds { get; set; }

        /// <summary>
        /// The maximum amount of time to wait between retries for job step execution.
        /// </summary>
        [JsonPropertyName("maximumRetryIntervalSeconds")]
        public int MaximumRetryIntervalSeconds { get; set; }

        /// <summary>
        /// Maximum number of times the job step will be reattempted if the first attempt fails.
        /// </summary>
        [JsonPropertyName("retryAttempts")]
        public int RetryAttempts { get; set; }

        /// <summary>
        /// The backoff multiplier for the time between retries.
        /// </summary>
        [JsonPropertyName("retryIntervalBackoffMultiplier")]
        public double RetryIntervalBackoffMultiplier { get; set; }

        /// <summary>
        /// Execution timeout for the job step.
        /// </summary>
        [JsonPropertyName("timeoutSeconds")]
        public int TimeoutSeconds { get; set; }
    }
}