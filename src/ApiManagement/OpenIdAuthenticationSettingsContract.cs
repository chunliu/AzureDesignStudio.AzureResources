// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// API OAuth2 Authentication settings details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class OpenIdAuthenticationSettingsContract
    {
        /// <summary>
        /// How to send token to the server.
        /// </summary>
        [JsonPropertyName("bearerTokenSendingMethods")]
        public IList<string> BearerTokenSendingMethods { get; set; }

        /// <summary>
        /// OAuth authorization server identifier.
        /// </summary>
        [JsonPropertyName("openidProviderId")]
        public string OpenidProviderId { get; set; }
    }
}