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
    /// Defines web application firewall policy properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class WebApplicationFirewallPolicyPropertiesFormat
    {
        /// <summary>
        /// The PolicySettings for policy.
        /// </summary>
        [JsonPropertyName("policySettings")]
        public PolicySettings PolicySettings { get; set; }

        /// <summary>
        /// The custom rules inside the policy.
        /// </summary>
        [JsonPropertyName("customRules")]
        public IList<WebApplicationFirewallCustomRule> CustomRules { get; set; }

        /// <summary>
        /// Describes the managedRules structure.
        /// </summary>
        [Required]
        [JsonPropertyName("managedRules")]
        public ManagedRulesDefinition ManagedRules { get; set; }
    }
}