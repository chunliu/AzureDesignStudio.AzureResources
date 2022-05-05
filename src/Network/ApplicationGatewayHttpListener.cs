// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Http listener of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayHttpListener
    {
        /// <summary>
        /// Properties of the application gateway HTTP listener.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayHttpListenerPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the HTTP listener that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}