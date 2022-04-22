using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Defines contents of a web application firewall global configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PolicySettings
    {
        /// <summary>
        /// The state of the policy.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The mode of the policy.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Whether to allow WAF to check request Body.
        /// </summary>
        [JsonPropertyName("requestBodyCheck")]
        public bool RequestBodyCheck { get; set; }

        /// <summary>
        /// Maximum request body size in Kb for WAF.
        /// </summary>
        [JsonPropertyName("maxRequestBodySizeInKb")]
        public int MaxRequestBodySizeInKb { get; set; }

        /// <summary>
        /// Maximum file upload size in Mb for WAF.
        /// </summary>
        [JsonPropertyName("fileUploadLimitInMb")]
        public int FileUploadLimitInMb { get; set; }
    }
}