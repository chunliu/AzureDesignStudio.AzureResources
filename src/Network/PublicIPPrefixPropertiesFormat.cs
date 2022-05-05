// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Public IP prefix properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PublicIPPrefixPropertiesFormat
    {
        /// <summary>
        /// The public IP address version.
        /// </summary>
        [JsonPropertyName("publicIPAddressVersion")]
        public string PublicIPAddressVersion { get; set; }

        /// <summary>
        /// The list of tags associated with the public IP prefix.
        /// </summary>
        [JsonPropertyName("ipTags")]
        public IList<IpTag> IpTags { get; set; }

        /// <summary>
        /// The Length of the Public IP Prefix.
        /// </summary>
        [JsonPropertyName("prefixLength")]
        public int PrefixLength { get; set; }

        /// <summary>
        /// The customIpPrefix that this prefix is associated with.
        /// </summary>
        [JsonPropertyName("customIPPrefix")]
        public SubResource CustomIPPrefix { get; set; }
    }
}