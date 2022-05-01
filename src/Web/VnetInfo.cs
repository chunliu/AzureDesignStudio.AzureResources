using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Virtual Network information contract.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VnetInfo
    {
        /// <summary>
        /// A certificate file (.cer) blob containing the public key of the private key used to authenticate a 
        [JsonPropertyName("certBlob")]
        public string CertBlob { get; set; }

        /// <summary>
        /// DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses.
        /// </summary>
        [JsonPropertyName("dnsServers")]
        public string DnsServers { get; set; }

        /// <summary>
        /// Flag that is used to denote if this is VNET injection
        /// </summary>
        [JsonPropertyName("isSwift")]
        public bool IsSwift { get; set; }

        /// <summary>
        /// The Virtual Network's resource ID.
        /// </summary>
        [JsonPropertyName("vnetResourceId")]
        public string VnetResourceId { get; set; }
    }
}