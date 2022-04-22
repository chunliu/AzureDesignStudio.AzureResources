using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Base
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FunctionOutput
    {
        /// <summary>
        /// Type of function output value
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Value assigned for function output
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}