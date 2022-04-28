using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a private endpoint connection.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PrivateEndpointConnectionProperties
    {
        [JsonPropertyName("privateEndpoint")]
        public PrivateEndpointProperty PrivateEndpoint { get; set; }
        [JsonPropertyName("privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; set; }
    }
}