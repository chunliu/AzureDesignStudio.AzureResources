// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AddressSpace
    {
        /// <summary>
        /// A list of address blocks reserved for this virtual network in CIDR notation.
        /// </summary>
        [Required]
        [JsonPropertyName("addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }
    }
}