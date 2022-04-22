using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of SSL certificates of application gateway.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VpnClientRootCertificatePropertiesFormat
    {
        /// <summary>
        /// The certificate public data.
        /// </summary>
        [Required]
        [JsonPropertyName("publicCertData")]
        public string PublicCertData { get; set; }
    }
}