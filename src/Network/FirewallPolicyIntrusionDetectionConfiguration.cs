// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The operation for configuring intrusion detection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FirewallPolicyIntrusionDetectionConfiguration
    {
        /// <summary>
        /// List of specific signatures states.
        /// </summary>
        [JsonPropertyName("signatureOverrides")]
        public IList<FirewallPolicyIntrusionDetectionSignatureSpecification> SignatureOverrides { get; set; }

        /// <summary>
        /// List of rules for traffic to bypass.
        /// </summary>
        [JsonPropertyName("bypassTrafficSettings")]
        public IList<FirewallPolicyIntrusionDetectionBypassTrafficSpecifications> BypassTrafficSettings { get; set; }
    }
}