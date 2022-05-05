// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PrivateDnsZoneGroupPropertiesFormat
    {
        /// <summary>
        /// A collection of private dns zone configurations of the private dns zone group.
        /// </summary>
        [JsonPropertyName("privateDnsZoneConfigs")]
        public IList<PrivateDnsZoneConfig> PrivateDnsZoneConfigs { get; set; }
    }
}