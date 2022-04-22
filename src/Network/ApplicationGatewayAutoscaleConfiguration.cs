using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Application Gateway autoscale configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayAutoscaleConfiguration
    {
        /// <summary>
        /// Lower bound on number of Application Gateway capacity.
        /// </summary>
        [Required]
        [JsonPropertyName("minCapacity")]
        public int MinCapacity { get; set; }

        /// <summary>
        /// Upper bound on number of Application Gateway capacity.
        /// </summary>
        [JsonPropertyName("maxCapacity")]
        public int MaxCapacity { get; set; }
    }
}