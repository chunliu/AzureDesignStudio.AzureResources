using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// RelayServiceConnectionEntity resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class RelayServiceConnectionEntityProperties
    {
        [JsonPropertyName("biztalkUri")]
        public string BiztalkUri { get; set; }
        [JsonPropertyName("entityConnectionString")]
        public string EntityConnectionString { get; set; }
        [JsonPropertyName("entityName")]
        public string EntityName { get; set; }
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }
        [JsonPropertyName("port")]
        public int Port { get; set; }
        [JsonPropertyName("resourceConnectionString")]
        public string ResourceConnectionString { get; set; }
        [JsonPropertyName("resourceType")]
        public string ResourceType { get; set; }
    }
}