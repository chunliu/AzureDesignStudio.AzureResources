// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of path rule of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayPathRulePropertiesFormat
    {
        /// <summary>
        /// Path rules of URL path map.
        /// </summary>
        [JsonPropertyName("paths")]
        public IList<string> Paths { get; set; }

        /// <summary>
        /// Backend address pool resource of URL path map path rule.
        /// </summary>
        [JsonPropertyName("backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Backend http settings resource of URL path map path rule.
        /// </summary>
        [JsonPropertyName("backendHttpSettings")]
        public SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Redirect configuration resource of URL path map path rule.
        /// </summary>
        [JsonPropertyName("redirectConfiguration")]
        public SubResource RedirectConfiguration { get; set; }

        /// <summary>
        /// Rewrite rule set resource of URL path map path rule.
        /// </summary>
        [JsonPropertyName("rewriteRuleSet")]
        public SubResource RewriteRuleSet { get; set; }

        /// <summary>
        /// Reference to the FirewallPolicy resource.
        /// </summary>
        [JsonPropertyName("firewallPolicy")]
        public SubResource FirewallPolicy { get; set; }
    }
}