using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the private dns zone group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PrivateDnsZoneGroupPropertiesFormat
    {
        /// <summary>
        /// A collection of private dns zone configurations of the private dns zone group.
        /// </summary>
        [JsonPropertyName("privateDnsZoneConfigs")]
        public IList<PrivateDnsZoneConfig> PrivateDnsZoneConfigs { get; set; }
    }
}