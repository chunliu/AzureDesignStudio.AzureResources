// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Google provider.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Google
    {
        /// <summary>
        /// <code>false</code> if the Google provider should not be enabled despite the set registration; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The configuration settings of the login flow, including the scopes that should be requested.
        /// </summary>
        [JsonPropertyName("login")]
        public LoginScopes Login { get; set; }

        /// <summary>
        /// The configuration settings of the app registration for providers that have client ids and client secrets
        /// </summary>
        [JsonPropertyName("registration")]
        public ClientRegistration Registration { get; set; }

        /// <summary>
        /// The configuration settings of the Allowed Audiences validation flow.
        /// </summary>
        [JsonPropertyName("validation")]
        public AllowedAudiencesValidation Validation { get; set; }
    }
}