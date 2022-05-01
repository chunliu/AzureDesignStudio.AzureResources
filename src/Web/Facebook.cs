using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Facebook provider.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Facebook
    {
        /// <summary>
        /// <code>false</code> if the Facebook provider should not be enabled despite the set registration; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The version of the Facebook api to be used while logging in.
        /// </summary>
        [JsonPropertyName("graphApiVersion")]
        public string GraphApiVersion { get; set; }

        /// <summary>
        /// The configuration settings of the login flow, including the scopes that should be requested.
        /// </summary>
        [JsonPropertyName("login")]
        public LoginScopes Login { get; set; }

        /// <summary>
        /// The configuration settings of the app registration for providers that have app ids and app secrets
        /// </summary>
        [JsonPropertyName("registration")]
        public AppRegistration Registration { get; set; }
    }
}