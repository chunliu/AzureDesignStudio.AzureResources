using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the Inbound Security Rules resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class InboundSecurityRules
    {
        /// <summary>
        /// Protocol. This should be either TCP or UDP.
        /// </summary>
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// The CIDR or source IP range. Only /30, /31 and /32 Ip ranges are allowed.
        /// </summary>
        [JsonPropertyName("sourceAddressPrefix")]
        public string SourceAddressPrefix { get; set; }

        /// <summary>
        /// NVA port ranges to be opened up. One needs to provide specific ports.
        /// </summary>
        [JsonPropertyName("destinationPortRange")]
        public int DestinationPortRange { get; set; }
    }
}