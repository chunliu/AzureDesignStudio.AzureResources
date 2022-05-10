// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// API Release details
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiReleaseContractProperties
    {
        /// <summary>
        /// Identifier of the API the release belongs to.
        /// </summary>
        [JsonPropertyName("apiId")]
        public string ApiId { get; set; }

        /// <summary>
        /// Release Notes
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    }
}