using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the custom Open ID Connect provider.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class CustomOpenIdConnectProvider
    {
        /// <summary>
        /// <code>false</code> if the custom Open ID provider provider should not be enabled; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The configuration settings of the login flow of the custom Open ID Connect provider.
        /// </summary>
        [JsonPropertyName("login")]
        public OpenIdConnectLogin Login { get; set; }

        /// <summary>
        /// The configuration settings of the app registration for the custom Open ID Connect provider.
        /// </summary>
        [JsonPropertyName("registration")]
        public OpenIdConnectRegistration Registration { get; set; }
    }
}