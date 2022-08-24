// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of an IPv6 server firewall rule.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IPv6ServerFirewallRuleProperties
    {
        /// <summary>
        /// The end IP address of the firewall rule. Must be IPv6 format. Must be greater than or equal to startIpAddress.
        /// </summary>
        [JsonPropertyName("endIPv6Address")]
        public string EndIPv6Address { get; set; }

        /// <summary>
        /// The start IP address of the firewall rule. Must be IPv6 format.
        /// </summary>
        [JsonPropertyName("startIPv6Address")]
        public string StartIPv6Address { get; set; }
    }
}