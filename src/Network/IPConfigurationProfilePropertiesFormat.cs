// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// IP configuration profile properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IPConfigurationProfilePropertiesFormat
    {
        /// <summary>
        /// The reference to the subnet resource to create a container network interface ip configuration.
        /// </summary>
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }
    }
}