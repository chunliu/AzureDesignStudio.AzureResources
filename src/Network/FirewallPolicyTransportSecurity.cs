using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Configuration needed to perform TLS termination & initiation.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FirewallPolicyTransportSecurity
    {
        /// <summary>
        /// The CA used for intermediate CA generation.
        /// </summary>
        [JsonPropertyName("certificateAuthority")]
        public FirewallPolicyCertificateAuthority CertificateAuthority { get; set; }
    }
}