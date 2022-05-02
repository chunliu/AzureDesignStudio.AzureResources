using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The blob service properties for Last access time based tracking policy.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class LastAccessTimeTrackingPolicy
    {
        /// <summary>
        /// An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently read only
        /// </summary>
        [JsonPropertyName("blobType")]
        public IList<string> BlobType { get; set; }

        /// <summary>
        /// When set to true last access time based tracking is enabled.
        /// </summary>
        [Required]
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Name of the policy. The valid value is AccessTimeTracking. This field is currently read only.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The field specifies blob object tracking granularity in days, typically how often the blob object should be tracked.This field is currently read only with value as 1
        /// </summary>
        [JsonPropertyName("trackingGranularityInDays")]
        public int TrackingGranularityInDays { get; set; }
    }
}