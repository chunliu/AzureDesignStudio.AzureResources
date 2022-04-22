using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/ipGroups
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IpGroups : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/ipGroups";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the IpGroups.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public IpGroupPropertiesFormat Properties { get; set; }
    }
}