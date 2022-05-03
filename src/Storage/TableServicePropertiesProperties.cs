using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The properties of a storage account’s Table service.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class TableServicePropertiesProperties
    {
        /// <summary>
        /// Sets the CORS rules. You can include up to five CorsRule elements in the request. 
        /// </summary>
        [JsonPropertyName("cors")]
        public CorsRules Cors { get; set; }
    }
}