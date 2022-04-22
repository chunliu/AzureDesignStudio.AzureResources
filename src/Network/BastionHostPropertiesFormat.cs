using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the Bastion Host.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BastionHostPropertiesFormat
    {
        /// <summary>
        /// IP configuration of the Bastion Host resource.
        /// </summary>
        [JsonPropertyName("ipConfigurations")]
        public IList<BastionHostIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// FQDN for the endpoint on which bastion host is accessible.
        /// </summary>
        [JsonPropertyName("dnsName")]
        public string DnsName { get; set; }
    }
}