// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// API OAuth2 Authentication settings details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class OAuth2AuthenticationSettingsContract
    {
        /// <summary>
        /// OAuth authorization server identifier.
        /// </summary>
        [JsonPropertyName("authorizationServerId")]
        public string AuthorizationServerId { get; set; }

        /// <summary>
        /// operations scope.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    }
}