// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Set of actions in the Rewrite Rule in Application Gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayRewriteRuleActionSet
    {
        /// <summary>
        /// Request Header Actions in the Action Set.
        /// </summary>
        [JsonPropertyName("requestHeaderConfigurations")]
        public IList<ApplicationGatewayHeaderConfiguration> RequestHeaderConfigurations { get; set; }

        /// <summary>
        /// Response Header Actions in the Action Set.
        /// </summary>
        [JsonPropertyName("responseHeaderConfigurations")]
        public IList<ApplicationGatewayHeaderConfiguration> ResponseHeaderConfigurations { get; set; }

        /// <summary>
        /// Url Configuration Action in the Action Set.
        /// </summary>
        [JsonPropertyName("urlConfiguration")]
        public ApplicationGatewayUrlConfiguration UrlConfiguration { get; set; }
    }
}