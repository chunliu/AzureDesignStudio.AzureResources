using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Sets the CORS rules. You can include up to five CorsRule elements in the request. 
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class CorsRules
    {
        /// <summary>
        /// The List of CORS rules. You can include up to five CorsRule elements in the request. 
        /// </summary>
        [JsonPropertyName("corsRules")]
        public IList<CorsRule> Rules { get; set; }
    }
}