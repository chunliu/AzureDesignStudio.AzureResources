using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VpnServerConfiguration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnServerConfigurationProperties
    {
        /// <summary>
        /// The name of the VpnServerConfiguration that is unique within a resource group.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// VPN protocols for the VpnServerConfiguration.
        /// </summary>
        [JsonPropertyName("vpnProtocols")]
        public IList<string> VpnProtocols { get; set; }

        /// <summary>
        /// VPN authentication types for the VpnServerConfiguration.
        /// </summary>
        [JsonPropertyName("vpnAuthenticationTypes")]
        public IList<string> VpnAuthenticationTypes { get; set; }

        /// <summary>
        /// VPN client root certificate of VpnServerConfiguration.
        /// </summary>
        [JsonPropertyName("vpnClientRootCertificates")]
        public IList<VpnServerConfigVpnClientRootCertificate> VpnClientRootCertificates { get; set; }

        /// <summary>
        /// VPN client revoked certificate of VpnServerConfiguration.
        /// </summary>
        [JsonPropertyName("vpnClientRevokedCertificates")]
        public IList<VpnServerConfigVpnClientRevokedCertificate> VpnClientRevokedCertificates { get; set; }

        /// <summary>
        /// Radius Server root certificate of VpnServerConfiguration.
        /// </summary>
        [JsonPropertyName("radiusServerRootCertificates")]
        public IList<VpnServerConfigRadiusServerRootCertificate> RadiusServerRootCertificates { get; set; }

        /// <summary>
        /// Radius client root certificate of VpnServerConfiguration.
        /// </summary>
        [JsonPropertyName("radiusClientRootCertificates")]
        public IList<VpnServerConfigRadiusClientRootCertificate> RadiusClientRootCertificates { get; set; }

        /// <summary>
        /// VpnClientIpsecPolicies for VpnServerConfiguration.
        /// </summary>
        [JsonPropertyName("vpnClientIpsecPolicies")]
        public IList<IpsecPolicy> VpnClientIpsecPolicies { get; set; }

        /// <summary>
        /// The radius server address property of the VpnServerConfiguration resource for point to site client connection.
        /// </summary>
        [JsonPropertyName("radiusServerAddress")]
        public string RadiusServerAddress { get; set; }

        /// <summary>
        /// The radius secret property of the VpnServerConfiguration resource for point to site client connection.
        /// </summary>
        [JsonPropertyName("radiusServerSecret")]
        public string RadiusServerSecret { get; set; }

        /// <summary>
        /// Multiple Radius Server configuration for VpnServerConfiguration.
        /// </summary>
        [JsonPropertyName("radiusServers")]
        public IList<RadiusServer> RadiusServers { get; set; }

        /// <summary>
        /// The set of aad vpn authentication parameters.
        /// </summary>
        [JsonPropertyName("aadAuthenticationParameters")]
        public AadAuthenticationParameters AadAuthenticationParameters { get; set; }
    }
}