using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Route resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class RoutePropertiesFormat
    {
        /// <summary>
        /// The destination CIDR to which the route applies.
        /// </summary>
        [Required]
        [JsonPropertyName("addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// The type of Azure hop the packet should be sent to.
        /// </summary>
        [Required]
        [JsonPropertyName("nextHopType")]
        public string NextHopType { get; set; }

        /// <summary>
        /// The IP address packets should be forwarded to. Next hop values are only allowed in routes where the next hop type is VirtualAppliance.
        /// </summary>
        [JsonPropertyName("nextHopIpAddress")]
        public string NextHopIpAddress { get; set; }

        /// <summary>
        /// A value indicating whether this route overrides overlapping BGP routes regardless of LPM.
        /// </summary>
        [JsonPropertyName("hasBgpOverride")]
        public bool HasBgpOverride { get; set; }
    }
}