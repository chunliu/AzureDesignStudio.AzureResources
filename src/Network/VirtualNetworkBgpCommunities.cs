// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualNetworkBgpCommunities
    {
        /// <summary>
        /// The BGP community associated with the virtual network.
        /// </summary>
        [Required]
        [JsonPropertyName("virtualNetworkCommunity")]
        public string VirtualNetworkCommunity { get; set; }
    }
}