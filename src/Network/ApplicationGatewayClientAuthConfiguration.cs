// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Application gateway client authentication configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayClientAuthConfiguration
    {
        /// <summary>
        /// Verify client certificate issuer name on the application gateway.
        /// </summary>
        [JsonPropertyName("verifyClientCertIssuerDN")]
        public bool VerifyClientCertIssuerDN { get; set; }
    }
}