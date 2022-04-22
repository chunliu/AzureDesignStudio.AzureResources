using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// List of properties of a link provider.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnLinkProviderProperties
    {
        /// <summary>
        /// Name of the link provider.
        /// </summary>
        [JsonPropertyName("linkProviderName")]
        public string LinkProviderName { get; set; }

        /// <summary>
        /// Link speed.
        /// </summary>
        [JsonPropertyName("linkSpeedInMbps")]
        public int LinkSpeedInMbps { get; set; }
    }
}