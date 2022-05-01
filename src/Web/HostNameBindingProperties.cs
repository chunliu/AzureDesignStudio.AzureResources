using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// HostNameBinding resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HostNameBindingProperties
    {
        /// <summary>
        /// Azure resource name.
        /// </summary>
        [JsonPropertyName("azureResourceName")]
        public string AzureResourceName { get; set; }

        /// <summary>
        /// Azure resource type.
        /// </summary>
        [JsonPropertyName("azureResourceType")]
        public string AzureResourceType { get; set; }

        /// <summary>
        /// Custom DNS record type.
        /// </summary>
        [JsonPropertyName("customHostNameDnsRecordType")]
        public string CustomHostNameDnsRecordType { get; set; }

        /// <summary>
        /// Fully qualified ARM domain resource URI.
        /// </summary>
        [JsonPropertyName("domainId")]
        public string DomainId { get; set; }

        /// <summary>
        /// Hostname type.
        /// </summary>
        [JsonPropertyName("hostNameType")]
        public string HostNameType { get; set; }

        /// <summary>
        /// App Service app name.
        /// </summary>
        [JsonPropertyName("siteName")]
        public string SiteName { get; set; }

        /// <summary>
        /// SSL type.
        /// </summary>
        [JsonPropertyName("sslState")]
        public string SslState { get; set; }

        /// <summary>
        /// SSL certificate thumbprint
        /// </summary>
        [JsonPropertyName("thumbprint")]
        public string Thumbprint { get; set; }
    }
}