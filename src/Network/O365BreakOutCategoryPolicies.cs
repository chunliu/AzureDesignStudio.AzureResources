using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Office365 breakout categories.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class O365BreakOutCategoryPolicies
    {
        /// <summary>
        /// Flag to control allow category.
        /// </summary>
        [JsonPropertyName("allow")]
        public bool Allow { get; set; }

        /// <summary>
        /// Flag to control optimize category.
        /// </summary>
        [JsonPropertyName("optimize")]
        public bool Optimize { get; set; }

        /// <summary>
        /// Flag to control default category.
        /// </summary>
        [JsonPropertyName("default")]
        public bool Default { get; set; }
    }
}