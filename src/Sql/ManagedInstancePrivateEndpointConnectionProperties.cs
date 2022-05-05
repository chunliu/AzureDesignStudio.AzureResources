// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a private endpoint connection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedInstancePrivateEndpointConnectionProperties
    {
        [JsonPropertyName("privateEndpoint")]
        public ManagedInstancePrivateEndpointProperty PrivateEndpoint { get; set; }
        [JsonPropertyName("privateLinkServiceConnectionState")]
        public ManagedInstancePrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; set; }
    }
}