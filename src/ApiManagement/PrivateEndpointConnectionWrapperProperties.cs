// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Properties of the PrivateEndpointConnectProperties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PrivateEndpointConnectionWrapperProperties
    {
        /// <summary>
        /// A wrapper for an ARM resource id
        /// </summary>
        [JsonPropertyName("privateEndpoint")]
        public ArmIdWrapper PrivateEndpoint { get; set; }

        /// <summary>
        /// A collection of information about the state of the connection between service consumer and provider.
        /// </summary>
        [Required]
        [JsonPropertyName("privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
    }
}