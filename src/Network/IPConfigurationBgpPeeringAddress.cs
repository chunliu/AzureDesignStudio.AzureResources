// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of IPConfigurationBgpPeeringAddress.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IPConfigurationBgpPeeringAddress
    {
        /// <summary>
        /// The ID of IP configuration which belongs to gateway.
        /// </summary>
        [JsonPropertyName("ipconfigurationId")]
        public string IpconfigurationId { get; set; }

        /// <summary>
        /// The list of custom BGP peering addresses which belong to IP configuration.
        /// </summary>
        [JsonPropertyName("customBgpIpAddresses")]
        public IList<string> CustomBgpIpAddresses { get; set; }
    }
}