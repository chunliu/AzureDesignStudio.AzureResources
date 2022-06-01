// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationProperties
    {
        /// <summary>
        /// Specify what happens to the public IP when the VM is deleted.
        /// </summary>
        [JsonPropertyName("deleteOption")]
        public string DeleteOption { get; set; }

        /// <summary>
        /// Describes a virtual machines scale sets network configuration's DNS settings.
        /// </summary>
        [JsonPropertyName("dnsSettings")]
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// The idle timeout of the public IP address.
        /// </summary>
        [JsonPropertyName("idleTimeoutInMinutes")]
        public int IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// The list of IP tags associated with the public IP address.
        /// </summary>
        [JsonPropertyName("ipTags")]
        public IList<VirtualMachineScaleSetIpTag> IpTags { get; set; }

        /// <summary>
        /// Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [JsonPropertyName("publicIPAddressVersion")]
        public string PublicIPAddressVersion { get; set; }
        [JsonPropertyName("publicIPPrefix")]
        public SubResource PublicIPPrefix { get; set; }
    }
}