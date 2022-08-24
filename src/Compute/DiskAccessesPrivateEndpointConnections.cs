// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Microsoft.Compute/diskAccesses/privateEndpointConnections
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DiskAccessesPrivateEndpointConnections : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2022-03-02";

        /// <summary>
        /// Properties of the PrivateEndpointConnectProperties.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public PrivateEndpointConnectionProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Compute/diskAccesses/privateEndpointConnections";
    }
}