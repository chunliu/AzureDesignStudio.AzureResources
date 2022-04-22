using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Base
{
    /// <summary>
    /// Output copy
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class OutputCopy
    {
        /// <summary>
        /// Count of the copy
        /// </summary>
        [Required]
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// Input of the copy
        /// </summary>
        [Required]
        [JsonPropertyName("input")]
        public string Input { get; set; }
    }
}