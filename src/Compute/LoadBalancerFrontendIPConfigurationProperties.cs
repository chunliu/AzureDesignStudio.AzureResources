// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a cloud service IP Configuration
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoadBalancerFrontendIPConfigurationProperties
    {
        /// <summary>
        /// The virtual network private IP address of the IP configuration.
        /// </summary>
        [JsonPropertyName("privateIPAddress")]
        public string PrivateIPAddress { get; set; }
        [JsonPropertyName("publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }
    }
}