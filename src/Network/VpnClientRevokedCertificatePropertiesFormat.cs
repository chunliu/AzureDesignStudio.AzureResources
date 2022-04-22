using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the revoked VPN client certificate of virtual network gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnClientRevokedCertificatePropertiesFormat
    {
        /// <summary>
        /// The revoked VPN client certificate thumbprint.
        /// </summary>
        [JsonPropertyName("thumbprint")]
        public string Thumbprint { get; set; }
    }
}