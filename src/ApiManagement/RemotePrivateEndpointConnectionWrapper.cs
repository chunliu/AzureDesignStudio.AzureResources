// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Remote Private Endpoint Connection resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RemotePrivateEndpointConnectionWrapper
    {
        /// <summary>
        /// Private Endpoint connection resource id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Private Endpoint Connection Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Properties of the PrivateEndpointConnectProperties.
        /// </summary>
        [JsonPropertyName("properties")]
        public PrivateEndpointConnectionWrapperProperties Properties { get; set; }

        /// <summary>
        /// Private Endpoint Connection Resource Type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}