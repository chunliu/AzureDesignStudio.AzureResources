// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayIPConfiguration
    {
        /// <summary>
        /// Properties of the application gateway IP configuration.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayIPConfigurationPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the IP configuration that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}