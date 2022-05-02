using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Setting for SMB protocol
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SmbSetting
    {
        /// <summary>
        /// SMB authentication methods supported by server. Valid values are NTLMv2, Kerberos. Should be passed as a string with delimiter ';'.
        /// </summary>
        [JsonPropertyName("authenticationMethods")]
        public string AuthenticationMethods { get; set; }

        /// <summary>
        /// SMB channel encryption supported by server. Valid values are AES-128-CCM, AES-128-GCM, AES-256-GCM. Should be passed as a string with delimiter ';'.
        /// </summary>
        [JsonPropertyName("channelEncryption")]
        public string ChannelEncryption { get; set; }

        /// <summary>
        /// Kerberos ticket encryption supported by server. Valid values are RC4-HMAC, AES-256. Should be passed as a string with delimiter ';'
        /// </summary>
        [JsonPropertyName("kerberosTicketEncryption")]
        public string KerberosTicketEncryption { get; set; }

        /// <summary>
        /// Multichannel setting. Applies to Premium FileStorage only.
        /// </summary>
        [JsonPropertyName("multichannel")]
        public Multichannel Multichannel { get; set; }

        /// <summary>
        /// SMB protocol versions supported by server. Valid values are SMB2.1, SMB3.0, SMB3.1.1. Should be passed as a string with delimiter ';'.
        /// </summary>
        [JsonPropertyName("versions")]
        public string Versions { get; set; }
    }
}