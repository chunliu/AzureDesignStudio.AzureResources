// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for HubVirtualNetworkConnection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class HubVirtualNetworkConnectionProperties
    {
        /// <summary>
        /// Reference to the remote virtual network.
        /// </summary>
        [JsonPropertyName("remoteVirtualNetwork")]
        public SubResource RemoteVirtualNetwork { get; set; }

        /// <summary>
        /// Deprecated: VirtualHub to RemoteVnet transit to enabled or not.
        /// </summary>
        [JsonPropertyName("allowHubToRemoteVnetTransit")]
        public bool AllowHubToRemoteVnetTransit { get; set; }

        /// <summary>
        /// Deprecated: Allow RemoteVnet to use Virtual Hub's gateways.
        /// </summary>
        [JsonPropertyName("allowRemoteVnetToUseHubVnetGateways")]
        public bool AllowRemoteVnetToUseHubVnetGateways { get; set; }

        /// <summary>
        /// Enable internet security.
        /// </summary>
        [JsonPropertyName("enableInternetSecurity")]
        public bool EnableInternetSecurity { get; set; }

        /// <summary>
        /// The Routing Configuration indicating the associated and propagated route tables on this connection.
        /// </summary>
        [JsonPropertyName("routingConfiguration")]
        public RoutingConfiguration RoutingConfiguration { get; set; }
    }
}