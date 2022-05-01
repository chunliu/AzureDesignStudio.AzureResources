using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// SiteAuthSettingsV2 resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SiteAuthSettingsV2Properties
    {
        /// <summary>
        /// The configuration settings that determines the validation flow of users using App Service Authentication/Authorization.
        /// </summary>
        [JsonPropertyName("globalValidation")]
        public GlobalValidation GlobalValidation { get; set; }

        /// <summary>
        /// The configuration settings of the HTTP requests for authentication and authorization requests made against App Service Authentication/Authorization.
        /// </summary>
        [JsonPropertyName("httpSettings")]
        public HttpSettings HttpSettings { get; set; }

        /// <summary>
        /// The configuration settings of each of the identity providers used to configure App Service Authentication/Authorization.
        /// </summary>
        [JsonPropertyName("identityProviders")]
        public IdentityProviders IdentityProviders { get; set; }

        /// <summary>
        /// The configuration settings of the login flow of users using App Service Authentication/Authorization.
        /// </summary>
        [JsonPropertyName("login")]
        public Login Login { get; set; }

        /// <summary>
        /// The configuration settings of the platform of App Service Authentication/Authorization.
        /// </summary>
        [JsonPropertyName("platform")]
        public AuthPlatform Platform { get; set; }
    }
}