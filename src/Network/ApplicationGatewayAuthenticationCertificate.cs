// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Authentication certificates of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayAuthenticationCertificate
    {
        /// <summary>
        /// Properties of the application gateway authentication certificate.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayAuthenticationCertificatePropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the authentication certificate that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}