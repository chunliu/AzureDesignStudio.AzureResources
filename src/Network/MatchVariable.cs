using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Define match variables.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class MatchVariable
    {
        /// <summary>
        /// Match Variable.
        /// </summary>
        [Required]
        [JsonPropertyName("variableName")]
        public string VariableName { get; set; }

        /// <summary>
        /// The selector of match variable.
        /// </summary>
        [JsonPropertyName("selector")]
        public string Selector { get; set; }
    }
}