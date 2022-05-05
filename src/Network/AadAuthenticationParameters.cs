// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// AAD Vpn authentication type related parameters.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AadAuthenticationParameters
    {
        /// <summary>
        /// AAD Vpn authentication parameter AAD tenant.
        /// </summary>
        [JsonPropertyName("aadTenant")]
        public string AadTenant { get; set; }

        /// <summary>
        /// AAD Vpn authentication parameter AAD audience.
        /// </summary>
        [JsonPropertyName("aadAudience")]
        public string AadAudience { get; set; }

        /// <summary>
        /// AAD Vpn authentication parameter AAD issuer.
        /// </summary>
        [JsonPropertyName("aadIssuer")]
        public string AadIssuer { get; set; }
    }
}