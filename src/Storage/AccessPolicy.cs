using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AccessPolicy
    {
        /// <summary>
        /// Expiry time of the access policy
        /// </summary>
        [JsonPropertyName("expiryTime")]
        public DateTime ExpiryTime { get; set; }

        /// <summary>
        /// List of abbreviated permissions.
        /// </summary>
        [JsonPropertyName("permission")]
        public string Permission { get; set; }

        /// <summary>
        /// Start time of the access policy
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }
    }
}