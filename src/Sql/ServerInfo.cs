using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Server info for the server trust group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServerInfo
    {
        /// <summary>
        /// Server Id.
        /// </summary>
        [Required]
        [JsonPropertyName("serverId")]
        public string ServerId { get; set; }
    }
}