using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/networkVirtualAppliances/virtualApplianceSites
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NetworkVirtualAppliances_virtualApplianceSites : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/networkVirtualAppliances/virtualApplianceSites";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// The properties of the Virtual Appliance Sites.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public VirtualApplianceSiteProperties Properties { get; set; }
    }
}