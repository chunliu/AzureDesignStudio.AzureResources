using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Application logs to file system configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FileSystemApplicationLogsConfig
    {
        /// <summary>
        /// Log level.
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }
    }
}