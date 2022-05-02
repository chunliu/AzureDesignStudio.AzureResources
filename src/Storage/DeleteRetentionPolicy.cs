using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The service properties for soft delete.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class DeleteRetentionPolicy
    {
        /// <summary>
        /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
        /// </summary>
        [JsonPropertyName("days")]
        public int Days { get; set; }

        /// <summary>
        /// Indicates whether DeleteRetentionPolicy is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}