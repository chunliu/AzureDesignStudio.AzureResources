// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkProfilePropertiesFormat
    {
        /// <summary>
        /// List of chid container network interface configurations.
        /// </summary>
        [JsonPropertyName("containerNetworkInterfaceConfigurations")]
        public IList<ContainerNetworkInterfaceConfiguration> ContainerNetworkInterfaceConfigurations { get; set; }
    }
}