using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// IP configuration of an Bastion Host.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BastionHostIPConfiguration
    {
        /// <summary>
        /// Represents the ip configuration associated with the resource.
        /// </summary>
        [JsonPropertyName("properties")]
        public BastionHostIPConfigurationPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}