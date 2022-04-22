using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The Office365 breakout policy.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class O365PolicyProperties
    {
        /// <summary>
        /// Office365 breakout categories.
        /// </summary>
        [JsonPropertyName("breakOutCategories")]
        public O365BreakOutCategoryPolicies BreakOutCategories { get; set; }
    }
}