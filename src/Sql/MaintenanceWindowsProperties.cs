// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class MaintenanceWindowsProperties
    {
        [JsonPropertyName("timeRanges")]
        public IList<MaintenanceWindowTimeRange> TimeRanges { get; set; }
    }
}