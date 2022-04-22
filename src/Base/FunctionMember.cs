using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Base
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FunctionMember
    {
        /// <summary>
        /// Function parameters
        /// </summary>
        [JsonPropertyName("parameters")]
        public IList<FunctionParameter> Parameters { get; set; }

        /// <summary>
        /// Function output
        /// </summary>
        [JsonPropertyName("output")]
        public FunctionOutput Output { get; set; }
    }
}