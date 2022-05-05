// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Http logs configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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