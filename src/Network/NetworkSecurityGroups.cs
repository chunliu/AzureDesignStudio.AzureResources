using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/networkSecurityGroups
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NetworkSecurityGroups : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/networkSecurityGroups";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the network security group.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public NetworkSecurityGroupPropertiesFormat Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<NetworkSecurityGroupsSecurityRules> Resources { get; set; }
    }
}