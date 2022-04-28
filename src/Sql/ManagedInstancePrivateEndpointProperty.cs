using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedInstancePrivateEndpointProperty
    {
        /// <summary>
        /// Resource id of the private endpoint.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}