using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties for a key execution.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedInstanceKeyProperties
    {
        /// <summary>
        /// The key type like 'ServiceManaged', 'AzureKeyVault'.
        /// </summary>
        [Required]
        [JsonPropertyName("serverKeyType")]
        public string ServerKeyType { get; set; }

        /// <summary>
        /// The URI of the key. If the ServerKeyType is AzureKeyVault, then the URI is required.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}