// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the login flow of the custom Open ID Connect provider.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class OpenIdConnectLogin
    {
        /// <summary>
        /// The name of the claim that contains the users name.
        /// </summary>
        [JsonPropertyName("nameClaimType")]
        public string NameClaimType { get; set; }

        /// <summary>
        /// A list of the scopes that should be requested while authenticating.
        /// </summary>
        [JsonPropertyName("scopes")]
        public IList<string> Scopes { get; set; }
    }
}