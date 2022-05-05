// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Trigger based on request execution time.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SlowRequestsBasedTrigger
    {
        /// <summary>
        /// Request Count.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Request Path.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// Time interval.
        /// </summary>
        [JsonPropertyName("timeInterval")]
        public string TimeInterval { get; set; }

        /// <summary>
        /// Time taken.
        /// </summary>
        [JsonPropertyName("timeTaken")]
        public string TimeTaken { get; set; }
    }
}