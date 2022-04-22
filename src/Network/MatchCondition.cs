using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Define match conditions.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class MatchCondition
    {
        /// <summary>
        /// List of match variables.
        /// </summary>
        [Required]
        [JsonPropertyName("matchVariables")]
        public IList<MatchVariable> MatchVariables { get; set; }

        /// <summary>
        /// The operator to be matched.
        /// </summary>
        [Required]
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// Whether this is negate condition or not.
        /// </summary>
        [JsonPropertyName("negationConditon")]
        public bool NegationConditon { get; set; }

        /// <summary>
        /// Match value.
        /// </summary>
        [Required]
        [JsonPropertyName("matchValues")]
        public IList<string> MatchValues { get; set; }

        /// <summary>
        /// List of transforms.
        /// </summary>
        [JsonPropertyName("transforms")]
        public IList<string> Transforms { get; set; }
    }
}