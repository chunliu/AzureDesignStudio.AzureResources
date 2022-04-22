using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Vpn NatRule mapping.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnNatRuleMapping
    {
        /// <summary>
        /// Address space for Vpn NatRule mapping.
        /// </summary>
        [JsonPropertyName("addressSpace")]
        public string AddressSpace { get; set; }
    }
}