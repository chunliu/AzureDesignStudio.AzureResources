// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Protected settings for the extension, referenced using KeyVault which are encrypted before sent to the role instance.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServiceVaultAndSecretReference
    {
        /// <summary>
        /// Secret URL which contains the protected settings of the extension
        /// </summary>
        [JsonPropertyName("secretUrl")]
        public string SecretUrl { get; set; }
        [JsonPropertyName("sourceVault")]
        public SubResource SourceVault { get; set; }
    }
}