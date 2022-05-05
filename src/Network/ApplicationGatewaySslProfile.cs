// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// SSL profile of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewaySslProfile
    {
        /// <summary>
        /// Properties of the application gateway SSL profile.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewaySslProfilePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the SSL profile that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}