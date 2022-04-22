using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Radius Server Settings.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class RadiusServer
    {
        /// <summary>
        /// The address of this radius server.
        /// </summary>
        [Required]
        [JsonPropertyName("radiusServerAddress")]
        public string RadiusServerAddress { get; set; }

        /// <summary>
        /// The initial score assigned to this radius server.
        /// </summary>
        [JsonPropertyName("radiusServerScore")]
        public int RadiusServerScore { get; set; }

        /// <summary>
        /// The secret used for this radius server.
        /// </summary>
        [JsonPropertyName("radiusServerSecret")]
        public string RadiusServerSecret { get; set; }
    }
}