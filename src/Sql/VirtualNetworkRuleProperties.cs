using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a virtual network rule.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualNetworkRuleProperties
    {
        /// <summary>
        /// Create firewall rule before the virtual network has vnet service endpoint enabled.
        /// </summary>
        [JsonPropertyName("ignoreMissingVnetServiceEndpoint")]
        public bool IgnoreMissingVnetServiceEndpoint { get; set; }

        /// <summary>
        /// The ARM resource id of the virtual network subnet.
        /// </summary>
        [Required]
        [JsonPropertyName("virtualNetworkSubnetId")]
        public string VirtualNetworkSubnetId { get; set; }
    }
}