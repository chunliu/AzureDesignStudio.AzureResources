using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SystemData
    {
        /// <summary>
        /// The timestamp of resource creation (UTC).
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The identity that created the resource.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The type of identity that created the resource.
        /// </summary>
        [JsonPropertyName("createdByType")]
        public string CreatedByType { get; set; }

        /// <summary>
        /// The timestamp of resource last modification (UTC)
        /// </summary>
        [JsonPropertyName("lastModifiedAt")]
        public DateTime LastModifiedAt { get; set; }

        /// <summary>
        /// The identity that last modified the resource.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// The type of identity that last modified the resource.
        /// </summary>
        [JsonPropertyName("lastModifiedByType")]
        public string LastModifiedByType { get; set; }
    }
}