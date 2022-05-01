using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the storage of the tokens if a file system is used.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FileSystemTokenStore
    {
        /// <summary>
        /// The directory in which the tokens will be stored.
        /// </summary>
        [JsonPropertyName("directory")]
        public string Directory { get; set; }
    }
}