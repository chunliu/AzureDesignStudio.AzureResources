// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of SSL certificates of application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VpnClientRootCertificatePropertiesFormat
    {
        /// <summary>
        /// The certificate public data.
        /// </summary>
        [Required]
        [JsonPropertyName("publicCertData")]
        public string PublicCertData { get; set; }
    }
}