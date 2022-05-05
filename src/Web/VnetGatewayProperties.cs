// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// VnetGateway resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VnetGatewayProperties
    {
        /// <summary>
        /// The Virtual Network name.
        /// </summary>
        [JsonPropertyName("vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// The URI where the VPN package can be downloaded.
        /// </summary>
        [Required]
        [JsonPropertyName("vpnPackageUri")]
        public string VpnPackageUri { get; set; }
    }
}