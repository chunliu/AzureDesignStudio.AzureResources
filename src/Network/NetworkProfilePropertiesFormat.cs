using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Network profile properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NetworkProfilePropertiesFormat
    {
        /// <summary>
        /// List of chid container network interface configurations.
        /// </summary>
        [JsonPropertyName("containerNetworkInterfaceConfigurations")]
        public IList<ContainerNetworkInterfaceConfiguration> ContainerNetworkInterfaceConfigurations { get; set; }
    }
}