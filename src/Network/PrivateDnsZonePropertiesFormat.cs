using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the private dns zone configuration resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PrivateDnsZonePropertiesFormat
    {
        /// <summary>
        /// The resource id of the private dns zone.
        /// </summary>
        [JsonPropertyName("privateDnsZoneId")]
        public string PrivateDnsZoneId { get; set; }
    }
}