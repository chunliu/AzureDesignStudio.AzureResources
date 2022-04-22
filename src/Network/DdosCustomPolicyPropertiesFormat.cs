using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// DDoS custom policy properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class DdosCustomPolicyPropertiesFormat
    {
        /// <summary>
        /// The protocol-specific DDoS policy customization parameters.
        /// </summary>
        [JsonPropertyName("protocolCustomSettings")]
        public IList<ProtocolCustomSettingsFormat> ProtocolCustomSettings { get; set; }
    }
}