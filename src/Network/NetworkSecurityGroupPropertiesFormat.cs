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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class NetworkSecurityGroupPropertiesFormat
    {
        /// <summary>
        /// A collection of security rules of the network security group.
        /// </summary>
        [JsonPropertyName("securityRules")]
        public IList<SecurityRule> SecurityRules { get; set; }
    }
}