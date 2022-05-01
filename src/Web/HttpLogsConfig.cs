using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Http logs configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HttpLogsConfig
    {
        /// <summary>
        /// Http logs to azure blob storage configuration.
        /// </summary>
        [JsonPropertyName("azureBlobStorage")]
        public AzureBlobStorageHttpLogsConfig AzureBlobStorage { get; set; }

        /// <summary>
        /// Http logs to file system configuration.
        /// </summary>
        [JsonPropertyName("fileSystem")]
        public FileSystemHttpLogsConfig FileSystem { get; set; }
    }
}