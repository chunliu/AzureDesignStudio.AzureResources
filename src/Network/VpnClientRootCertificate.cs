// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VPN client root certificate of virtual network gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VpnClientRootCertificate
    {
        /// <summary>
        /// Properties of the vpn client root certificate.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public VpnClientRootCertificatePropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}