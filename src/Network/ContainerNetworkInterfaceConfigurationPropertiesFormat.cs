using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Container network interface configuration properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ContainerNetworkInterfaceConfigurationPropertiesFormat
    {
        /// <summary>
        /// A list of ip configurations of the container network interface configuration.
        /// </summary>
        [JsonPropertyName("ipConfigurations")]
        public IList<IPConfigurationProfile> IpConfigurations { get; set; }

        /// <summary>
        /// A list of container network interfaces created from this container network interface configuration.
        /// </summary>
        [JsonPropertyName("containerNetworkInterfaces")]
        public IList<SubResource> ContainerNetworkInterfaces { get; set; }
    }
}