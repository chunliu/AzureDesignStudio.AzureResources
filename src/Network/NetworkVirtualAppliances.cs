using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/networkVirtualAppliances
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NetworkVirtualAppliances : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/networkVirtualAppliances";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the Network Virtual Appliance.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public NetworkVirtualAppliancePropertiesFormat Properties { get; set; }

        /// <summary>
        /// The service principal that has read access to cloud-init and config blob.
        /// </summary>
        [JsonPropertyName("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        [JsonPropertyName("resources")]
        public IList<NetworkVirtualAppliancesInboundSecurityRules> Resources { get; set; }
    }
}