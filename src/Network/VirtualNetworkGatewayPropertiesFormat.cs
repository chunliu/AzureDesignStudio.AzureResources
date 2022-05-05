// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VirtualNetworkGateway properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualNetworkGatewayPropertiesFormat
    {
        /// <summary>
        /// IP configurations for virtual network gateway.
        /// </summary>
        [JsonPropertyName("ipConfigurations")]
        public IList<VirtualNetworkGatewayIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// The type of this virtual network gateway.
        /// </summary>
        [JsonPropertyName("gatewayType")]
        public string GatewayType { get; set; }

        /// <summary>
        /// The type of this virtual network gateway.
        /// </summary>
        [JsonPropertyName("vpnType")]
        public string VpnType { get; set; }

        /// <summary>
        /// The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.
        /// </summary>
        [JsonPropertyName("vpnGatewayGeneration")]
        public string VpnGatewayGeneration { get; set; }

        /// <summary>
        /// Whether BGP is enabled for this virtual network gateway or not.
        /// </summary>
        [JsonPropertyName("enableBgp")]
        public bool EnableBgp { get; set; }

        /// <summary>
        /// Whether private IP needs to be enabled on this gateway for connections or not.
        /// </summary>
        [JsonPropertyName("enablePrivateIpAddress")]
        public bool EnablePrivateIpAddress { get; set; }

        /// <summary>
        /// ActiveActive flag.
        /// </summary>
        [JsonPropertyName("activeActive")]
        public bool ActiveActive { get; set; }

        /// <summary>
        /// The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
        /// </summary>
        [JsonPropertyName("gatewayDefaultSite")]
        public SubResource GatewayDefaultSite { get; set; }

        /// <summary>
        /// The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
        /// </summary>
        [JsonPropertyName("sku")]
        public VirtualNetworkGatewaySku Sku { get; set; }

        /// <summary>
        /// The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
        /// </summary>
        [JsonPropertyName("vpnClientConfiguration")]
        public VpnClientConfiguration VpnClientConfiguration { get; set; }

        /// <summary>
        /// Virtual network gateway's BGP speaker settings.
        /// </summary>
        [JsonPropertyName("bgpSettings")]
        public BgpSettings BgpSettings { get; set; }

        /// <summary>
        /// The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
        /// </summary>
        [JsonPropertyName("customRoutes")]
        public AddressSpace CustomRoutes { get; set; }

        /// <summary>
        /// Whether dns forwarding is enabled or not.
        /// </summary>
        [JsonPropertyName("enableDnsForwarding")]
        public bool EnableDnsForwarding { get; set; }

        /// <summary>
        /// MAS FIJI customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet.
        /// </summary>
        [JsonPropertyName("vNetExtendedLocationResourceId")]
        public string VNetExtendedLocationResourceId { get; set; }

        /// <summary>
        /// The extended location of type local virtual network gateway.
        /// </summary>
        [JsonPropertyName("virtualNetworkExtendedLocation")]
        public ExtendedLocation VirtualNetworkExtendedLocation { get; set; }
    }
}