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
    /// An traffic selector policy for a virtual network gateway connection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TrafficSelectorPolicy
    {
        /// <summary>
        /// A collection of local address spaces in CIDR format.
        /// </summary>
        [Required]
        [JsonPropertyName("localAddressRanges")]
        public IList<string> LocalAddressRanges { get; set; }

        /// <summary>
        /// A collection of remote address spaces in CIDR format.
        /// </summary>
        [Required]
        [JsonPropertyName("remoteAddressRanges")]
        public IList<string> RemoteAddressRanges { get; set; }
    }
}