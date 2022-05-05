// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the Inbound Security Rules resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class InboundSecurityRuleProperties
    {
        /// <summary>
        /// List of allowed rules.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<InboundSecurityRules> Rules { get; set; }
    }
}