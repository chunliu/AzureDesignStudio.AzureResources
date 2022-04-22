using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the application rule protocol.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureFirewallApplicationRuleProtocol
    {
        /// <summary>
        /// Protocol type.
        /// </summary>
        [JsonPropertyName("protocolType")]
        public string ProtocolType { get; set; }

        /// <summary>
        /// Port number for the protocol, cannot be greater than 64000. This field is optional.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }
    }
}