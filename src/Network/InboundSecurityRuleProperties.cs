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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class InboundSecurityRuleProperties
    {
        /// <summary>
        /// List of allowed rules.
        /// </summary>
        [JsonPropertyName("rules")]
        public IList<InboundSecurityRules> Rules { get; set; }
    }
}