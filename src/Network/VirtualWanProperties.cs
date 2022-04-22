using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters for VirtualWAN.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualWanProperties
    {
        /// <summary>
        /// Vpn encryption to be disabled or not.
        /// </summary>
        [JsonPropertyName("disableVpnEncryption")]
        public bool DisableVpnEncryption { get; set; }

        /// <summary>
        /// True if branch to branch traffic is allowed.
        /// </summary>
        [JsonPropertyName("allowBranchToBranchTraffic")]
        public bool AllowBranchToBranchTraffic { get; set; }

        /// <summary>
        /// True if Vnet to Vnet traffic is allowed.
        /// </summary>
        [JsonPropertyName("allowVnetToVnetTraffic")]
        public bool AllowVnetToVnetTraffic { get; set; }

        /// <summary>
        /// The office local breakout category.
        /// </summary>
        [JsonPropertyName("office365LocalBreakoutCategory")]
        public string Office365LocalBreakoutCategory { get; set; }

        /// <summary>
        /// The type of the VirtualWAN.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}