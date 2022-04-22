using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// IP configuration profile child resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IPConfigurationProfile
    {
        /// <summary>
        /// Properties of the IP configuration profile.
        /// </summary>
        [JsonPropertyName("properties")]
        public IPConfigurationProfilePropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}