// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Contains the DDoS protection settings of the public IP.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DdosSettings
    {
        /// <summary>
        /// The DDoS custom policy associated with the public IP.
        /// </summary>
        [JsonPropertyName("ddosCustomPolicy")]
        public SubResource DdosCustomPolicy { get; set; }

        /// <summary>
        /// The DDoS protection policy customizability of the public IP. Only standard coverage will have the ability to be customized.
        /// </summary>
        [JsonPropertyName("protectionCoverage")]
        public string ProtectionCoverage { get; set; }

        /// <summary>
        /// Enables DDoS protection on the public IP.
        /// </summary>
        [JsonPropertyName("protectedIP")]
        public bool ProtectedIP { get; set; }
    }
}