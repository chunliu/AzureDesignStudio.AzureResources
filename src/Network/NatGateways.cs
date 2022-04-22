using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/natGateways
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NatGateways : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/natGateways";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// The nat gateway SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public NatGatewaySku Sku { get; set; }

        /// <summary>
        /// Nat Gateway properties.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public NatGatewayPropertiesFormat Properties { get; set; }

        /// <summary>
        /// A list of availability zones denoting the zone in which Nat Gateway should be deployed.
        /// </summary>
        [JsonPropertyName("zones")]
        public IList<string> Zones { get; set; }
    }
}