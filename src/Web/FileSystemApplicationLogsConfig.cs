// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Application logs to file system configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FileSystemApplicationLogsConfig
    {
        /// <summary>
        /// Log level.
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }
    }
}