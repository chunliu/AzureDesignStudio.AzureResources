using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Allow to exclude some variable satisfy the condition for the WAF check.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class OwaspCrsExclusionEntry
    {
        /// <summary>
        /// The variable to be excluded.
        /// </summary>
        [Required]
        [JsonPropertyName("matchVariable")]
        public string MatchVariable { get; set; }

        /// <summary>
        /// When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to.
        /// </summary>
        [Required]
        [JsonPropertyName("selectorMatchOperator")]
        public string SelectorMatchOperator { get; set; }

        /// <summary>
        /// When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to.
        /// </summary>
        [Required]
        [JsonPropertyName("selector")]
        public string Selector { get; set; }
    }
}