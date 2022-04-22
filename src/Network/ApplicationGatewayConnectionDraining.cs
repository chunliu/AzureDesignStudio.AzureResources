using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Connection draining allows open connections to a backend server to be active for a specified time after the backend server got removed from the configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayConnectionDraining
    {
        /// <summary>
        /// Whether connection draining is enabled or not.
        /// </summary>
        [Required]
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds.
        /// </summary>
        [Required]
        [JsonPropertyName("drainTimeoutInSec")]
        public int DrainTimeoutInSec { get; set; }
    }
}