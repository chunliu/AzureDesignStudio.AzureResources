using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Protocol settings for file service
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ProtocolSettings
    {
        /// <summary>
        /// Setting for SMB protocol
        /// </summary>
        [JsonPropertyName("smb")]
        public SmbSetting Smb { get; set; }
    }
}