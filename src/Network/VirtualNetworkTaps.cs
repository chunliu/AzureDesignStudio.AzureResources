using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/virtualNetworkTaps
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualNetworkTaps : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/virtualNetworkTaps";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Virtual Network Tap Properties.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public VirtualNetworkTapPropertiesFormat Properties { get; set; }
    }
}