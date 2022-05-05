// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the Azure Firewall.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AzureFirewallPropertiesFormat
    {
        /// <summary>
        /// Collection of application rule collections used by Azure Firewall.
        /// </summary>
        [JsonPropertyName("applicationRuleCollections")]
        public IList<AzureFirewallApplicationRuleCollection> ApplicationRuleCollections { get; set; }

        /// <summary>
        /// Collection of NAT rule collections used by Azure Firewall.
        /// </summary>
        [JsonPropertyName("natRuleCollections")]
        public IList<AzureFirewallNatRuleCollection> NatRuleCollections { get; set; }

        /// <summary>
        /// Collection of network rule collections used by Azure Firewall.
        /// </summary>
        [JsonPropertyName("networkRuleCollections")]
        public IList<AzureFirewallNetworkRuleCollection> NetworkRuleCollections { get; set; }

        /// <summary>
        /// IP configuration of the Azure Firewall resource.
        /// </summary>
        [JsonPropertyName("ipConfigurations")]
        public IList<AzureFirewallIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// IP configuration of the Azure Firewall used for management traffic.
        /// </summary>
        [JsonPropertyName("managementIpConfiguration")]
        public AzureFirewallIPConfiguration ManagementIpConfiguration { get; set; }

        /// <summary>
        /// The operation mode for Threat Intelligence.
        /// </summary>
        [JsonPropertyName("threatIntelMode")]
        public string ThreatIntelMode { get; set; }

        /// <summary>
        /// The virtualHub to which the firewall belongs.
        /// </summary>
        [JsonPropertyName("virtualHub")]
        public SubResource VirtualHub { get; set; }

        /// <summary>
        /// The firewallPolicy associated with this azure firewall.
        /// </summary>
        [JsonPropertyName("firewallPolicy")]
        public SubResource FirewallPolicy { get; set; }

        /// <summary>
        /// IP addresses associated with AzureFirewall.
        /// </summary>
        [JsonPropertyName("hubIPAddresses")]
        public HubIPAddresses HubIPAddresses { get; set; }

        /// <summary>
        /// The Azure Firewall Resource SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public AzureFirewallSku Sku { get; set; }

        /// <summary>
        /// The additional properties used to further config this azure firewall.
        /// </summary>
        [JsonPropertyName("additionalProperties")]
        public IDictionary<string, string> AdditionalProperties { get; set; }
    }
}