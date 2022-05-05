// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Vpn NatRule mapping.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VpnNatRuleMapping
    {
        /// <summary>
        /// Address space for Vpn NatRule mapping.
        /// </summary>
        [JsonPropertyName("addressSpace")]
        public string AddressSpace { get; set; }
    }
}