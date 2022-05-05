// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Public IP address properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PublicIPAddressPropertiesFormat
    {
        /// <summary>
        /// The public IP address allocation method.
        /// </summary>
        [Required]
        [JsonPropertyName("publicIPAllocationMethod")]
        public string PublicIPAllocationMethod { get; set; }

        /// <summary>
        /// The public IP address version.
        /// </summary>
        [JsonPropertyName("publicIPAddressVersion")]
        public string PublicIPAddressVersion { get; set; }

        /// <summary>
        /// The FQDN of the DNS record associated with the public IP address.
        /// </summary>
        [JsonPropertyName("dnsSettings")]
        public PublicIPAddressDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// The DDoS protection custom policy associated with the public IP address.
        /// </summary>
        [JsonPropertyName("ddosSettings")]
        public DdosSettings DdosSettings { get; set; }

        /// <summary>
        /// The list of tags associated with the public IP address.
        /// </summary>
        [JsonPropertyName("ipTags")]
        public IList<IpTag> IpTags { get; set; }

        /// <summary>
        /// The IP address associated with the public IP address resource.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The Public IP Prefix this Public IP Address should be allocated from.
        /// </summary>
        [JsonPropertyName("publicIPPrefix")]
        public SubResource PublicIPPrefix { get; set; }

        /// <summary>
        /// The idle timeout of the public IP address.
        /// </summary>
        [JsonPropertyName("idleTimeoutInMinutes")]
        public int IdleTimeoutInMinutes { get; set; }
    }
}