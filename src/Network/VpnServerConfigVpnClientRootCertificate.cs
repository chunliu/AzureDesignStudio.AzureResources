// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of VPN client root certificate of VpnServerConfiguration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VpnServerConfigVpnClientRootCertificate
    {
        /// <summary>
        /// The certificate name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The certificate public data.
        /// </summary>
        [JsonPropertyName("publicCertData")]
        public string PublicCertData { get; set; }
    }
}