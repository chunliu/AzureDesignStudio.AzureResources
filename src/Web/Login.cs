// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the login flow of users using App Service Authentication/Authorization.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Login
    {
        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        [JsonPropertyName("allowedExternalRedirectUrls")]
        public IList<string> AllowedExternalRedirectUrls { get; set; }

        /// <summary>
        /// The configuration settings of the session cookie's expiration.
        /// </summary>
        [JsonPropertyName("cookieExpiration")]
        public CookieExpiration CookieExpiration { get; set; }

        /// <summary>
        /// The configuration settings of the nonce used in the login flow.
        /// </summary>
        [JsonPropertyName("nonce")]
        public Nonce Nonce { get; set; }

        /// <summary>
        /// <code>true</code> if the fragments from the request are preserved after the login request is made; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("preserveUrlFragmentsForLogins")]
        public bool PreserveUrlFragmentsForLogins { get; set; }

        /// <summary>
        /// The routes that specify the endpoints used for login and logout requests.
        /// </summary>
        [JsonPropertyName("routes")]
        public LoginRoutes Routes { get; set; }

        /// <summary>
        /// The configuration settings of the token store.
        /// </summary>
        [JsonPropertyName("tokenStore")]
        public TokenStore TokenStore { get; set; }
    }
}