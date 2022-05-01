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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class LoginScopes
    {
        /// <summary>
        /// A list of the scopes that should be requested while authenticating.
        /// </summary>
        [JsonPropertyName("scopes")]
        public IList<string> Scopes { get; set; }
    }
}