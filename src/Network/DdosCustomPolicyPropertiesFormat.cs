// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DdosCustomPolicyPropertiesFormat
    {
        /// <summary>
        /// The protocol-specific DDoS policy customization parameters.
        /// </summary>
        [JsonPropertyName("protocolCustomSettings")]
        public IList<ProtocolCustomSettingsFormat> ProtocolCustomSettings { get; set; }
    }
}