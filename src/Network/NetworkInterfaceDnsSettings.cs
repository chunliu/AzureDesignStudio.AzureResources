// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// DNS settings of a network interface.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkInterfaceDnsSettings
    {
        /// <summary>
        /// List of DNS servers IP addresses. Use 'AzureProvidedDNS' to switch to azure provided DNS resolution. 'AzureProvidedDNS' value cannot be combined with other IPs, it must be the only value in dnsServers collection.
        /// </summary>
        [JsonPropertyName("dnsServers")]
        public IList<string> DnsServers { get; set; }

        /// <summary>
        /// Relative DNS name for this NIC used for internal communications between VMs in the same virtual network.
        /// </summary>
        [JsonPropertyName("internalDnsNameLabel")]
        public string InternalDnsNameLabel { get; set; }
    }
}