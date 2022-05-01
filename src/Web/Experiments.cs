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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Experiments
    {
        /// <summary>
        /// List of ramp-up rules.
        /// </summary>
        [JsonPropertyName("rampUpRules")]
        public IList<RampUpRule> RampUpRules { get; set; }
    }
}