// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Application logs to Azure table storage configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AzureTableStorageApplicationLogsConfig
    {
        /// <summary>
        /// Log level.
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// SAS URL to an Azure table with add/query/delete permissions.
        /// </summary>
        [Required]
        [JsonPropertyName("sasUrl")]
        public string SasUrl { get; set; }
    }
}