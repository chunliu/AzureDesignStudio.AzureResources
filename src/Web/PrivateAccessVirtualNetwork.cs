// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Description of a Virtual Network that is useable for private site access.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PrivateAccessVirtualNetwork
    {
        /// <summary>
        /// The key (ID) of the Virtual Network.
        /// </summary>
        [JsonPropertyName("key")]
        public int Key { get; set; }

        /// <summary>
        /// The name of the Virtual Network.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The ARM uri of the Virtual Network
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// A List of subnets that access is allowed to on this Virtual Network. An empty array (but not null) is interpreted to mean that all subnets are allowed within this Virtual Network.
        /// </summary>
        [JsonPropertyName("subnets")]
        public IList<PrivateAccessSubnet> Subnets { get; set; }
    }
}