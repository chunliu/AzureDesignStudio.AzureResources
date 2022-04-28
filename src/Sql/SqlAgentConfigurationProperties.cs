using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Sql agent configuration properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SqlAgentConfigurationProperties
    {
        /// <summary>
        /// The state of Sql Agent.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}