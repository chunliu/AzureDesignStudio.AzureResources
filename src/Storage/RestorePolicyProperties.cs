using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The blob service properties for blob restore policy
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class RestorePolicyProperties
    {
        /// <summary>
        /// how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days.
        /// </summary>
        [JsonPropertyName("days")]
        public int Days { get; set; }

        /// <summary>
        /// Blob restore is enabled if set to true.
        /// </summary>
        [Required]
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}