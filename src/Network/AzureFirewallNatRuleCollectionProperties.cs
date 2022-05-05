// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the NAT rule collection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AzureFirewallNatRuleCollectionProperties
    {
        /// <summary>
        /// Priority of the NAT rule collection resource.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// The action type of a NAT rule collection.
        /// </summary>
        [JsonPropertyName("action")]
        public AzureFirewallNatRCAction Action { get; set; }

        /// <summary>
        /// Collection of rules used by a NAT rule collection.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<AzureFirewallNatRule> Rules { get; set; }
    }
}