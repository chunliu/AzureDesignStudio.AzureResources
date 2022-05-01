using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Application logs configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationLogsConfig
    {
        /// <summary>
        /// Application logs azure blob storage configuration.
        /// </summary>
        [JsonPropertyName("azureBlobStorage")]
        public AzureBlobStorageApplicationLogsConfig AzureBlobStorage { get; set; }

        /// <summary>
        /// Application logs to Azure table storage configuration.
        /// </summary>
        [JsonPropertyName("azureTableStorage")]
        public AzureTableStorageApplicationLogsConfig AzureTableStorage { get; set; }

        /// <summary>
        /// Application logs to file system configuration.
        /// </summary>
        [JsonPropertyName("fileSystem")]
        public FileSystemApplicationLogsConfig FileSystem { get; set; }
    }
}