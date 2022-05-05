// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Path rule of URL path map of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayPathRule
    {
        /// <summary>
        /// Properties of the application gateway path rule.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayPathRulePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the path rule that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}