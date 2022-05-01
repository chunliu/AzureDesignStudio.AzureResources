using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Triggers for auto-heal.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AutoHealTriggers
    {
        /// <summary>
        /// A rule based on private bytes.
        /// </summary>
        [JsonPropertyName("privateBytesInKB")]
        public int PrivateBytesInKB { get; set; }

        /// <summary>
        /// Trigger based on total requests.
        /// </summary>
        [JsonPropertyName("requests")]
        public RequestsBasedTrigger Requests { get; set; }

        /// <summary>
        /// Trigger based on request execution time.
        /// </summary>
        [JsonPropertyName("slowRequests")]
        public SlowRequestsBasedTrigger SlowRequests { get; set; }

        /// <summary>
        /// A rule based on multiple Slow Requests Rule with path
        /// </summary>
        [JsonPropertyName("slowRequestsWithPath")]
        public IList<SlowRequestsBasedTrigger> SlowRequestsWithPath { get; set; }

        /// <summary>
        /// A rule based on status codes.
        /// </summary>
        [JsonPropertyName("statusCodes")]
        public IList<StatusCodesBasedTrigger> StatusCodes { get; set; }

        /// <summary>
        /// A rule based on status codes ranges.
        /// </summary>
        [JsonPropertyName("statusCodesRange")]
        public IList<StatusCodesRangeBasedTrigger> StatusCodesRange { get; set; }
    }
}