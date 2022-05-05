// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Network Security Group resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkSecurityGroupPropertiesFormat
    {
        /// <summary>
        /// A collection of security rules of the network security group.
        /// </summary>
        [JsonPropertyName("securityRules")]
        public IList<SecurityRule> SecurityRules { get; set; }
    }
}