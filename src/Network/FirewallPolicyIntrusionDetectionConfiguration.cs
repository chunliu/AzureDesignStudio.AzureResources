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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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