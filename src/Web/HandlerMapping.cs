using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The IIS handler mappings used to define which handler processes HTTP requests with certain extension. 
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HandlerMapping
    {
        /// <summary>
        /// Command-line arguments to be passed to the script processor.
        /// </summary>
        [JsonPropertyName("arguments")]
        public string Arguments { get; set; }

        /// <summary>
        /// Requests with this extension will be handled using the specified FastCGI application.
        /// </summary>
        [JsonPropertyName("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// The absolute path to the FastCGI application.
        /// </summary>
        [JsonPropertyName("scriptProcessor")]
        public string ScriptProcessor { get; set; }
    }
}