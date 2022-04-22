using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// SKU of nat gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NatGatewaySku
    {
        /// <summary>
        /// Name of Nat Gateway SKU.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}