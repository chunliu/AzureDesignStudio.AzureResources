// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the login flow, including the scopes that should be requested.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoginScopes
    {
        /// <summary>
        /// A list of the scopes that should be requested while authenticating.
        /// </summary>
        [JsonPropertyName("scopes")]
        public IList<string> Scopes { get; set; }
    }
}