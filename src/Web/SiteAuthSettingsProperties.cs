using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// SiteAuthSettings resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SiteAuthSettingsProperties
    {
        /// <summary>
        /// Gets a JSON string containing the Azure AD Acl settings.
        /// </summary>
        [JsonPropertyName("aadClaimsAuthorization")]
        public string AadClaimsAuthorization { get; set; }

        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        [JsonPropertyName("additionalLoginParams")]
        public IList<string> AdditionalLoginParams { get; set; }

        /// <summary>
        /// Allowed audience values to consider when validating JWTs issued by 
        [JsonPropertyName("allowedAudiences")]
        public IList<string> AllowedAudiences { get; set; }

        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        [JsonPropertyName("allowedExternalRedirectUrls")]
        public IList<string> AllowedExternalRedirectUrls { get; set; }

        /// <summary>
        /// The path of the config file containing auth settings.
        [JsonPropertyName("authFilePath")]
        public string AuthFilePath { get; set; }

        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// The Client Secret of this relying party application (in Azure Active Directory, this is also referred to as the Key).
        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        [JsonPropertyName("clientSecretCertificateThumbprint")]
        public string ClientSecretCertificateThumbprint { get; set; }

        /// <summary>
        /// The app setting name that contains the client secret of the relying party application.
        /// </summary>
        [JsonPropertyName("clientSecretSettingName")]
        public string ClientSecretSettingName { get; set; }

        /// <summary>
        /// The ConfigVersion of the Authentication / Authorization feature in use for the current app.
        [JsonPropertyName("configVersion")]
        public string ConfigVersion { get; set; }

        /// <summary>
        /// The default authentication provider to use when multiple providers are configured.
        [JsonPropertyName("defaultProvider")]
        public string DefaultProvider { get; set; }

        /// <summary>
        /// <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The App ID of the Facebook app used for login.
        [JsonPropertyName("facebookAppId")]
        public string FacebookAppId { get; set; }

        /// <summary>
        /// The App Secret of the Facebook app used for Facebook Login.
        [JsonPropertyName("facebookAppSecret")]
        public string FacebookAppSecret { get; set; }

        /// <summary>
        /// The app setting name that contains the app secret used for Facebook Login.
        /// </summary>
        [JsonPropertyName("facebookAppSecretSettingName")]
        public string FacebookAppSecretSettingName { get; set; }

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication.
        [JsonPropertyName("facebookOAuthScopes")]
        public IList<string> FacebookOAuthScopes { get; set; }

        /// <summary>
        /// The Client Id of the GitHub app used for login.
        [JsonPropertyName("gitHubClientId")]
        public string GitHubClientId { get; set; }

        /// <summary>
        /// The Client Secret of the GitHub app used for Github Login.
        [JsonPropertyName("gitHubClientSecret")]
        public string GitHubClientSecret { get; set; }

        /// <summary>
        /// The app setting name that contains the client secret of the Github
        [JsonPropertyName("gitHubClientSecretSettingName")]
        public string GitHubClientSecretSettingName { get; set; }

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
        [JsonPropertyName("gitHubOAuthScopes")]
        public IList<string> GitHubOAuthScopes { get; set; }

        /// <summary>
        /// The OpenID Connect Client ID for the Google web application.
        [JsonPropertyName("googleClientId")]
        public string GoogleClientId { get; set; }

        /// <summary>
        /// The client secret associated with the Google web application.
        [JsonPropertyName("googleClientSecret")]
        public string GoogleClientSecret { get; set; }

        /// <summary>
        /// The app setting name that contains the client secret associated with 
        [JsonPropertyName("googleClientSecretSettingName")]
        public string GoogleClientSecretSettingName { get; set; }

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication.
        [JsonPropertyName("googleOAuthScopes")]
        public IList<string> GoogleOAuthScopes { get; set; }

        /// <summary>
        /// "true" if the auth config settings should be read from a file,
        [JsonPropertyName("isAuthFromFile")]
        public string IsAuthFromFile { get; set; }

        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The OAuth 2.0 client ID that was created for the app used for authentication.
        [JsonPropertyName("microsoftAccountClientId")]
        public string MicrosoftAccountClientId { get; set; }

        /// <summary>
        /// The OAuth 2.0 client secret that was created for the app used for authentication.
        [JsonPropertyName("microsoftAccountClientSecret")]
        public string MicrosoftAccountClientSecret { get; set; }

        /// <summary>
        /// The app setting name containing the OAuth 2.0 client secret that was created for the
        [JsonPropertyName("microsoftAccountClientSecretSettingName")]
        public string MicrosoftAccountClientSecretSettingName { get; set; }

        /// <summary>
        /// The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication.
        [JsonPropertyName("microsoftAccountOAuthScopes")]
        public IList<string> MicrosoftAccountOAuthScopes { get; set; }

        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        [JsonPropertyName("runtimeVersion")]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// The number of hours after session token expiration that a session token can be used to
        [JsonPropertyName("tokenRefreshExtensionHours")]
        public double TokenRefreshExtensionHours { get; set; }

        /// <summary>
        /// <code>true</code> to durably store platform-specific security tokens that are obtained during login flows; otherwise, <code>false</code>.
        [JsonPropertyName("tokenStoreEnabled")]
        public bool TokenStoreEnabled { get; set; }

        /// <summary>
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        [JsonPropertyName("twitterConsumerKey")]
        public string TwitterConsumerKey { get; set; }

        /// <summary>
        /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in.
        [JsonPropertyName("twitterConsumerSecret")]
        public string TwitterConsumerSecret { get; set; }

        /// <summary>
        /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        [JsonPropertyName("twitterConsumerSecretSettingName")]
        public string TwitterConsumerSecretSettingName { get; set; }

        /// <summary>
        /// The action to take when an unauthenticated client attempts to access the app.
        /// </summary>
        [JsonPropertyName("unauthenticatedClientAction")]
        public string UnauthenticatedClientAction { get; set; }

        /// <summary>
        /// Gets a value indicating whether the issuer should be a valid HTTPS url and be validated as such.
        /// </summary>
        [JsonPropertyName("validateIssuer")]
        public bool ValidateIssuer { get; set; }
    }
}