// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Nat Gateway properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NatGatewayPropertiesFormat
    {
        /// <summary>
        /// The idle timeout of the nat gateway.
        /// </summary>
        [JsonPropertyName("idleTimeoutInMinutes")]
        public int IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// An array of public ip addresses associated with the nat gateway resource.
        /// </summary>
        [JsonPropertyName("publicIpAddresses")]
        public IList<SubResource> PublicIpAddresses { get; set; }

        /// <summary>
        /// An array of public ip prefixes associated with the nat gateway resource.
        /// </summary>
        [JsonPropertyName("publicIpPrefixes")]
        public IList<SubResource> PublicIpPrefixes { get; set; }
    }
}