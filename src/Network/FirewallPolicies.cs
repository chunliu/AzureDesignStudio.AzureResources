using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/firewallPolicies
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicies : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/firewallPolicies";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the firewall policy.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public FirewallPolicyPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The identity of the firewall policy.
        /// </summary>
        [JsonPropertyName("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        [JsonPropertyName("resources")]
        public IList<FirewallPoliciesRuleCollectionGroups> Resources { get; set; }
    }
}