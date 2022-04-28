using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Maintenance windows resource properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class MaintenanceWindowsProperties
    {
        [JsonPropertyName("timeRanges")]
        public IList<MaintenanceWindowTimeRange> TimeRanges { get; set; }
    }
}