using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VPN client revoked certificate of virtual network gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnClientRevokedCertificate
    {
        /// <summary>
        /// Properties of the vpn client revoked certificate.
        /// </summary>
        [JsonPropertyName("properties")]
        public VpnClientRevokedCertificatePropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}