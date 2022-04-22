using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VpnClientConfiguration for P2S client.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnClientConfiguration
    {
        /// <summary>
        /// The reference to the address space resource which represents Address space for P2S VpnClient.
        /// </summary>
        [JsonPropertyName("vpnClientAddressPool")]
        public AddressSpace VpnClientAddressPool { get; set; }

        /// <summary>
        /// VpnClientRootCertificate for virtual network gateway.
        /// </summary>
        [JsonPropertyName("vpnClientRootCertificates")]
        public IList<VpnClientRootCertificate> VpnClientRootCertificates { get; set; }

        /// <summary>
        /// VpnClientRevokedCertificate for Virtual network gateway.
        /// </summary>
        [JsonPropertyName("vpnClientRevokedCertificates")]
        public IList<VpnClientRevokedCertificate> VpnClientRevokedCertificates { get; set; }

        /// <summary>
        /// VpnClientProtocols for Virtual network gateway.
        /// </summary>
        [JsonPropertyName("vpnClientProtocols")]
        public IList<string> VpnClientProtocols { get; set; }

        /// <summary>
        /// VPN authentication types for the virtual network gateway..
        /// </summary>
        [JsonPropertyName("vpnAuthenticationTypes")]
        public IList<string> VpnAuthenticationTypes { get; set; }

        /// <summary>
        /// VpnClientIpsecPolicies for virtual network gateway P2S client.
        /// </summary>
        [JsonPropertyName("vpnClientIpsecPolicies")]
        public IList<IpsecPolicy> VpnClientIpsecPolicies { get; set; }

        /// <summary>
        /// The radius server address property of the VirtualNetworkGateway resource for vpn client connection.
        /// </summary>
        [JsonPropertyName("radiusServerAddress")]
        public string RadiusServerAddress { get; set; }

        /// <summary>
        /// The radius secret property of the VirtualNetworkGateway resource for vpn client connection.
        /// </summary>
        [JsonPropertyName("radiusServerSecret")]
        public string RadiusServerSecret { get; set; }

        /// <summary>
        /// The radiusServers property for multiple radius server configuration.
        /// </summary>
        [JsonPropertyName("radiusServers")]
        public IList<RadiusServer> RadiusServers { get; set; }

        /// <summary>
        /// The AADTenant property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication.
        /// </summary>
        [JsonPropertyName("aadTenant")]
        public string AadTenant { get; set; }

        /// <summary>
        /// The AADAudience property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication.
        /// </summary>
        [JsonPropertyName("aadAudience")]
        public string AadAudience { get; set; }

        /// <summary>
        /// The AADIssuer property of the VirtualNetworkGateway resource for vpn client connection used for AAD authentication.
        /// </summary>
        [JsonPropertyName("aadIssuer")]
        public string AadIssuer { get; set; }
    }
}