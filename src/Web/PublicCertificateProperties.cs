using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// PublicCertificate resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PublicCertificateProperties
    {
        /// <summary>
        /// Public Certificate byte array
        /// </summary>
        [JsonPropertyName("blob")]
        public string Blob { get; set; }

        /// <summary>
        /// Public Certificate Location.
        /// </summary>
        [JsonPropertyName("publicCertificateLocation")]
        public string PublicCertificateLocation { get; set; }
    }
}