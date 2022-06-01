// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machines network configuration's DNS settings.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineNetworkInterfaceDnsSettingsConfiguration
    {
        /// <summary>
        /// List of DNS servers IP addresses
        /// </summary>
        [JsonPropertyName("dnsServers")]
        public IList<string> DnsServers { get; set; }
    }
}