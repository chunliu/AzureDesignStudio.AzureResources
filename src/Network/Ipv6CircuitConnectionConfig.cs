using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// IPv6 Circuit Connection properties for global reach.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Ipv6CircuitConnectionConfig
    {
        /// <summary>
        /// /125 IP address space to carve out customer addresses for global reach.
        /// </summary>
        [JsonPropertyName("addressPrefix")]
        public string AddressPrefix { get; set; }
    }
}