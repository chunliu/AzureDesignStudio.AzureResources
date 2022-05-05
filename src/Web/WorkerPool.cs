// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Worker pool of an App Service Environment.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class WorkerPool
    {
        /// <summary>
        /// Shared or dedicated app hosting.
        /// </summary>
        [JsonPropertyName("computeMode")]
        public string ComputeMode { get; set; }

        /// <summary>
        /// Number of instances in the worker pool.
        /// </summary>
        [JsonPropertyName("workerCount")]
        public int WorkerCount { get; set; }

        /// <summary>
        /// VM size of the worker pool instances.
        /// </summary>
        [JsonPropertyName("workerSize")]
        public string WorkerSize { get; set; }

        /// <summary>
        /// Worker size ID for referencing this worker pool.
        /// </summary>
        [JsonPropertyName("workerSizeId")]
        public int WorkerSizeId { get; set; }
    }
}