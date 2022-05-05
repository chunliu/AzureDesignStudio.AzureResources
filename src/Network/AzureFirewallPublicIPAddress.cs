// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Public IP Address associated with azure firewall.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AzureFirewallPublicIPAddress
    {
        /// <summary>
        /// Public IP Address value.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}