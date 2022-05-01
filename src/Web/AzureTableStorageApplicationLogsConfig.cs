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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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