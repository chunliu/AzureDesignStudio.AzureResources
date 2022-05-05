// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// PrivateAccess resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PrivateAccessProperties
    {
        /// <summary>
        /// Whether private access is enabled or not.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The Virtual Networks (and subnets) allowed to access the site privately.
        /// </summary>
        [JsonPropertyName("virtualNetworks")]
        public IList<PrivateAccessVirtualNetwork> VirtualNetworks { get; set; }
    }
}