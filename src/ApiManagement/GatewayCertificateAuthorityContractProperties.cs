// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Gateway certificate authority details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GatewayCertificateAuthorityContractProperties
    {
        /// <summary>
        /// Determines whether certificate authority is trusted.
        /// </summary>
        [JsonPropertyName("isTrusted")]
        public bool IsTrusted { get; set; }
    }
}