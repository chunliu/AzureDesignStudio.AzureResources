// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the Security Partner Provider.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SecurityPartnerProviderPropertiesFormat
    {
        /// <summary>
        /// The security provider name.
        /// </summary>
        [JsonPropertyName("securityProviderName")]
        public string SecurityProviderName { get; set; }

        /// <summary>
        /// The virtualHub to which the Security Partner Provider belongs.
        /// </summary>
        [JsonPropertyName("virtualHub")]
        public SubResource VirtualHub { get; set; }
    }
}