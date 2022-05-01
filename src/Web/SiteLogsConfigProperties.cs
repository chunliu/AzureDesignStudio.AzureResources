using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// SiteLogsConfig resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SiteLogsConfigProperties
    {
        /// <summary>
        /// Application logs configuration.
        /// </summary>
        [JsonPropertyName("applicationLogs")]
        public ApplicationLogsConfig ApplicationLogs { get; set; }

        /// <summary>
        /// Enabled configuration.
        /// </summary>
        [JsonPropertyName("detailedErrorMessages")]
        public EnabledConfig DetailedErrorMessages { get; set; }

        /// <summary>
        /// Enabled configuration.
        /// </summary>
        [JsonPropertyName("failedRequestsTracing")]
        public EnabledConfig FailedRequestsTracing { get; set; }

        /// <summary>
        /// Http logs configuration.
        /// </summary>
        [JsonPropertyName("httpLogs")]
        public HttpLogsConfig HttpLogs { get; set; }
    }
}