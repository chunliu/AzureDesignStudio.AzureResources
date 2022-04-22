using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The service endpoint properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServiceEndpointPropertiesFormat
    {
        /// <summary>
        /// The type of the endpoint service.
        /// </summary>
        [JsonPropertyName("service")]
        public string Service { get; set; }

        /// <summary>
        /// A list of locations.
        /// </summary>
        [JsonPropertyName("locations")]
        public IList<string> Locations { get; set; }
    }
}