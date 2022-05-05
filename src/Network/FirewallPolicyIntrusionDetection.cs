// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Configuration for intrusion detection mode and rules.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FirewallPolicyIntrusionDetection
    {
        /// <summary>
        /// Intrusion detection general state.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Intrusion detection configuration properties.
        /// </summary>
        [JsonPropertyName("configuration")]
        public FirewallPolicyIntrusionDetectionConfiguration Configuration { get; set; }
    }
}