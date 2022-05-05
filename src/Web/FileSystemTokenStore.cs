// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the storage of the tokens if a file system is used.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FileSystemTokenStore
    {
        /// <summary>
        /// The directory in which the tokens will be stored.
        /// </summary>
        [JsonPropertyName("directory")]
        public string Directory { get; set; }
    }
}