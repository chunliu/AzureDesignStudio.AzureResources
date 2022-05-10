// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// API Authentication Settings.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AuthenticationSettingsContract
    {
        /// <summary>
        /// API OAuth2 Authentication settings details.
        /// </summary>
        [JsonPropertyName("oAuth2")]
        public OAuth2AuthenticationSettingsContract OAuth2 { get; set; }

        /// <summary>
        /// API OAuth2 Authentication settings details.
        /// </summary>
        [JsonPropertyName("openid")]
        public OpenIdAuthenticationSettingsContract Openid { get; set; }
    }
}