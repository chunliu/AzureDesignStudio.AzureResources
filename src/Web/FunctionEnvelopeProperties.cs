using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// FunctionEnvelope resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FunctionEnvelopeProperties
    {
        /// <summary>
        /// Config information.
        /// </summary>
        [JsonPropertyName("config")]
        public object Config { get; set; }

        /// <summary>
        /// Config URI.
        /// </summary>
        [JsonPropertyName("config_href")]
        public string Config_href { get; set; }

        /// <summary>
        /// File list.
        /// </summary>
        [JsonPropertyName("files")]
        public IDictionary<string, string> Files { get; set; }

        /// <summary>
        /// Function App ID.
        /// </summary>
        [JsonPropertyName("function_app_id")]
        public string Function_app_id { get; set; }

        /// <summary>
        /// Function URI.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        /// The invocation URL
        /// </summary>
        [JsonPropertyName("invoke_url_template")]
        public string Invoke_url_template { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the function is disabled
        /// </summary>
        [JsonPropertyName("isDisabled")]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// The function language
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Script URI.
        /// </summary>
        [JsonPropertyName("script_href")]
        public string Script_href { get; set; }

        /// <summary>
        /// Script root path URI.
        /// </summary>
        [JsonPropertyName("script_root_path_href")]
        public string Script_root_path_href { get; set; }

        /// <summary>
        /// Secrets file URI.
        /// </summary>
        [JsonPropertyName("secrets_file_href")]
        public string Secrets_file_href { get; set; }

        /// <summary>
        /// Test data used when testing via the Azure Portal.
        /// </summary>
        [JsonPropertyName("test_data")]
        public string Test_data { get; set; }

        /// <summary>
        /// Test data URI.
        /// </summary>
        [JsonPropertyName("test_data_href")]
        public string Test_data_href { get; set; }
    }
}