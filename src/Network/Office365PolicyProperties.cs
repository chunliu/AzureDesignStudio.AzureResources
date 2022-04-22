using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Network Virtual Appliance Sku Properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Office365PolicyProperties
    {
        /// <summary>
        /// Office 365 breakout categories.
        /// </summary>
        [JsonPropertyName("breakOutCategories")]
        public BreakOutCategoryPolicies BreakOutCategories { get; set; }
    }
}