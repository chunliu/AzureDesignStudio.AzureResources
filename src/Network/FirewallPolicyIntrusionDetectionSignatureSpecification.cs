using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Intrusion detection signatures specification states.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicyIntrusionDetectionSignatureSpecification
    {
        /// <summary>
        /// Signature id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The signature state.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }
    }
}