// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Custom IP prefix properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CustomIpPrefixPropertiesFormat
    {
        /// <summary>
        /// The prefix range in CIDR notation. Should include the start address and the prefix length.
        /// </summary>
        [JsonPropertyName("cidr")]
        public string Cidr { get; set; }

        /// <summary>
        /// The commissioned state of the Custom IP Prefix.
        /// </summary>
        [JsonPropertyName("commissionedState")]
        public string CommissionedState { get; set; }
    }
}