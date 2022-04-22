using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The HTTP header.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HTTPHeader
    {
        /// <summary>
        /// The name in HTTP header.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value in HTTP header.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}