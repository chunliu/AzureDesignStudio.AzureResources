// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the connection monitor endpoint.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ConnectionMonitorEndpoint
    {
        /// <summary>
        /// The name of the connection monitor endpoint.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The endpoint type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Resource ID of the connection monitor endpoint.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Address of the connection monitor endpoint (IP or domain name).
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Filter for sub-items within the endpoint.
        /// </summary>
        [JsonPropertyName("filter")]
        public ConnectionMonitorEndpointFilter Filter { get; set; }

        /// <summary>
        /// Endpoint scope.
        /// </summary>
        [JsonPropertyName("scope")]
        public ConnectionMonitorEndpointScope Scope { get; set; }

        /// <summary>
        /// Test coverage for the endpoint.
        /// </summary>
        [JsonPropertyName("coverageLevel")]
        public string CoverageLevel { get; set; }
    }
}