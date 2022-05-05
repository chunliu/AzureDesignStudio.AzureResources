// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Http logs to azure blob storage configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AzureBlobStorageHttpLogsConfig
    {
        /// <summary>
        /// True if configuration is enabled, false if it is disabled and null if configuration is not set.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Retention in days.
        [JsonPropertyName("retentionInDays")]
        public int RetentionInDays { get; set; }

        /// <summary>
        /// SAS url to a azure blob container with read/write/list/delete permissions.
        /// </summary>
        [JsonPropertyName("sasUrl")]
        public string SasUrl { get; set; }
    }
}