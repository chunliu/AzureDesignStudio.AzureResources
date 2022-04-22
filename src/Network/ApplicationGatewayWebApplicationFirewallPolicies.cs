using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayWebApplicationFirewallPolicies : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the web application firewall policy.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public WebApplicationFirewallPolicyPropertiesFormat Properties { get; set; }
    }
}