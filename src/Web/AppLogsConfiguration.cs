using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AppLogsConfiguration
    {
        [JsonPropertyName("destination")]
        public string Destination { get; set; }
        [JsonPropertyName("logAnalyticsConfiguration")]
        public LogAnalyticsConfiguration LogAnalyticsConfiguration { get; set; }
    }
}