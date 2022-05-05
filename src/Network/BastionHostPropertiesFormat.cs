// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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