// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VpnGatewayNatRule.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VpnGatewayNatRuleProperties
    {
        /// <summary>
        /// The type of NAT rule for VPN NAT.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The Source NAT direction of a VPN NAT.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// The private IP address internal mapping for NAT.
        /// </summary>
        [JsonPropertyName("internalMappings")]
        public IList<VpnNatRuleMapping> InternalMappings { get; set; }

        /// <summary>
        /// The private IP address external mapping for NAT.
        /// </summary>
        [JsonPropertyName("externalMappings")]
        public IList<VpnNatRuleMapping> ExternalMappings { get; set; }

        /// <summary>
        /// The IP Configuration ID this NAT rule applies to.
        /// </summary>
        [JsonPropertyName("ipConfigurationId")]
        public string IpConfigurationId { get; set; }
    }
}