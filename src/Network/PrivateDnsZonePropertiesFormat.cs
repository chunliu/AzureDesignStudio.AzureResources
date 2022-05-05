// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the private dns zone configuration resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PrivateDnsZonePropertiesFormat
    {
        /// <summary>
        /// The resource id of the private dns zone.
        /// </summary>
        [JsonPropertyName("privateDnsZoneId")]
        public string PrivateDnsZoneId { get; set; }
    }
}