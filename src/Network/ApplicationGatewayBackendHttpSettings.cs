// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Backend address pool settings of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayBackendHttpSettings
    {
        /// <summary>
        /// Properties of the application gateway backend HTTP settings.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayBackendHttpSettingsPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the backend http settings that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}