// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The private IP addresses/IP ranges to which traffic will not be SNAT.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FirewallPolicySNAT
    {
        /// <summary>
        /// List of private IP addresses/IP address ranges to not be SNAT.
        /// </summary>
        [JsonPropertyName("privateRanges")]
        public IList<string> PrivateRanges { get; set; }
    }
}