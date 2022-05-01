using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// AseV3NetworkingConfiguration resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AseV3NetworkingConfigurationProperties
    {
        /// <summary>
        /// Property to enable and disable new private endpoint connection creation on ASE
        /// </summary>
        [JsonPropertyName("allowNewPrivateEndpointConnections")]
        public bool AllowNewPrivateEndpointConnections { get; set; }
    }
}