using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of Radius Server root certificate of VpnServerConfiguration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnServerConfigRadiusServerRootCertificate
    {
        /// <summary>
        /// The certificate name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The certificate public data.
        /// </summary>
        [JsonPropertyName("publicCertData")]
        public string PublicCertData { get; set; }
    }
}