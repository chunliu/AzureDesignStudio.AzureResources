// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App container Custom scaling rule.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class HttpScaleRule
    {
        /// <summary>
        /// Authentication secrets for the custom scale rule.
        /// </summary>
        [JsonPropertyName("auth")]
        public IList<ScaleRuleAuth> Auth { get; set; }

        /// <summary>
        /// Metadata properties to describe http scale rule.
        /// </summary>
        [JsonPropertyName("metadata")]
        public IDictionary<string, string> Metadata { get; set; }
    }
}