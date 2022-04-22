using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Container network interface configuration child resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ContainerNetworkInterfaceConfiguration
    {
        /// <summary>
        /// Container network interface configuration properties.
        /// </summary>
        [JsonPropertyName("properties")]
        public ContainerNetworkInterfaceConfigurationPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}