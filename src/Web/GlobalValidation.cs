// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings that determines the validation flow of users using App Service Authentication/Authorization.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GlobalValidation
    {
        /// <summary>
        /// The paths for which unauthenticated flow would not be redirected to the login page.
        /// </summary>
        [JsonPropertyName("excludedPaths")]
        public IList<string> ExcludedPaths { get; set; }

        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        [JsonPropertyName("redirectToProvider")]
        public string RedirectToProvider { get; set; }

        /// <summary>
        /// <code>true</code> if the authentication flow is required any request is made; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("requireAuthentication")]
        public bool RequireAuthentication { get; set; }

        /// <summary>
        /// The action to take when an unauthenticated client attempts to access the app.
        /// </summary>
        [JsonPropertyName("unauthenticatedClientAction")]
        public string UnauthenticatedClientAction { get; set; }
    }
}