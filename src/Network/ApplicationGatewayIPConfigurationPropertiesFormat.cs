// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of IP configuration of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayIPConfigurationPropertiesFormat
    {
        /// <summary>
        /// Reference to the subnet resource. A subnet from where application gateway gets its private address.
        /// </summary>
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }
    }
}