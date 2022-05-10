// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Microsoft.ApiManagement/service/privateEndpointConnections
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServicePrivateEndpointConnections : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-04-01-preview";

        /// <summary>
        /// Private Endpoint Connection Resource Id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The connection state of the private endpoint connection.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public PrivateEndpointConnectionRequestProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.ApiManagement/service/privateEndpointConnections";
    }
}