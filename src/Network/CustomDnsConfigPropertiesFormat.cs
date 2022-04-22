using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Contains custom Dns resolution configuration from customer.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class CustomDnsConfigPropertiesFormat
    {
        /// <summary>
        /// Fqdn that resolves to private endpoint ip address.
        /// </summary>
        [JsonPropertyName("fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// A list of private ip addresses of the private endpoint.
        /// </summary>
        [JsonPropertyName("ipAddresses")]
        public IList<string> IpAddresses { get; set; }
    }
}