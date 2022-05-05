// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Routing rules in production experiments.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Experiments
    {
        /// <summary>
        /// List of ramp-up rules.
        /// </summary>
        [JsonPropertyName("rampUpRules")]
        public IList<RampUpRule> RampUpRules { get; set; }
    }
}