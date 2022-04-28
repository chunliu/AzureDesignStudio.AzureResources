using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a server firewall rule.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServerFirewallRuleProperties
    {
        /// <summary>
        /// The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress. Use value '0.0.0.0' for all Azure-internal IP addresses.
        /// </summary>
        [JsonPropertyName("endIpAddress")]
        public string EndIpAddress { get; set; }

        /// <summary>
        /// The start IP address of the firewall rule. Must be IPv4 format. Use value '0.0.0.0' for all Azure-internal IP addresses.
        /// </summary>
        [JsonPropertyName("startIpAddress")]
        public string StartIpAddress { get; set; }
    }
}