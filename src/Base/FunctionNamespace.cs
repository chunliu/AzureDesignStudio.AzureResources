using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Base
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FunctionNamespace
    {
        /// <summary>
        /// Function namespace
        /// </summary>
        [JsonPropertyName("namespace")]
        public string Namespace { get; set; }

        /// <summary>
        /// Function members
        /// </summary>
        [JsonPropertyName("members")]
        public IDictionary<string, FunctionMember> Members { get; set; }
    }
}