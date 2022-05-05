// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties for a server key execution.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServerKeyProperties
    {
        /// <summary>
        /// The server key type like 'ServiceManaged', 'AzureKeyVault'.
        /// </summary>
        [Required]
        [JsonPropertyName("serverKeyType")]
        public string ServerKeyType { get; set; }

        /// <summary>
        /// The URI of the server key. If the ServerKeyType is AzureKeyVault, then the URI is required.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}