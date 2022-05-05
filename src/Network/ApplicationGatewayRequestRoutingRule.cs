// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Request routing rule of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayRequestRoutingRule
    {
        /// <summary>
        /// Properties of the application gateway request routing rule.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayRequestRoutingRulePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the request routing rule that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}