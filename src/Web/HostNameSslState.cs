using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// SSL-enabled hostname.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HostNameSslState
    {
        /// <summary>
        /// Indicates whether the hostname is a standard or repository hostname.
        /// </summary>
        [JsonPropertyName("hostType")]
        public string HostType { get; set; }

        /// <summary>
        /// Hostname.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// SSL type.
        /// </summary>
        [JsonPropertyName("sslState")]
        public string SslState { get; set; }

        /// <summary>
        /// SSL certificate thumbprint.
        /// </summary>
        [JsonPropertyName("thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Set to <code>true</code> to update existing hostname.
        /// </summary>
        [JsonPropertyName("toUpdate")]
        public bool ToUpdate { get; set; }

        /// <summary>
        /// Virtual IP address assigned to the hostname if IP based SSL is enabled.
        /// </summary>
        [JsonPropertyName("virtualIP")]
        public string VirtualIP { get; set; }
    }
}