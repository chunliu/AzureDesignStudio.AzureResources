// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// The external Identity Providers like Facebook, Google, Microsoft, Twitter or Azure Active Directory which can be used to enable access to the API Management service developer portal for all users.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IdentityProviderCreateContractProperties
    {
        /// <summary>
        /// List of Allowed Tenants when configuring Azure Active Directory login.
        /// </summary>
        [JsonPropertyName("allowedTenants")]
        public IList<string> AllowedTenants { get; set; }

        /// <summary>
        /// OpenID Connect discovery endpoint hostname for AAD or AAD B2C.
        /// </summary>
        [JsonPropertyName("authority")]
        public string Authority { get; set; }

        /// <summary>
        /// Client Id of the Application in the external Identity Provider. It is App ID for Facebook login, Client ID for Google login, App ID for Microsoft.
        /// </summary>
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Client secret of the Application in external Identity Provider, used to authenticate login request. For example, it is App Secret for Facebook login, API Key for Google login, Public Key for Microsoft. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
        /// </summary>
        [Required]
        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Password Reset Policy Name. Only applies to AAD B2C Identity Provider.
        /// </summary>
        [JsonPropertyName("passwordResetPolicyName")]
        public string PasswordResetPolicyName { get; set; }

        /// <summary>
        /// Profile Editing Policy Name. Only applies to AAD B2C Identity Provider.
        /// </summary>
        [JsonPropertyName("profileEditingPolicyName")]
        public string ProfileEditingPolicyName { get; set; }

        /// <summary>
        /// Signin Policy Name. Only applies to AAD B2C Identity Provider.
        /// </summary>
        [JsonPropertyName("signinPolicyName")]
        public string SigninPolicyName { get; set; }

        /// <summary>
        /// The TenantId to use instead of Common when logging into Active Directory
        /// </summary>
        [JsonPropertyName("signinTenant")]
        public string SigninTenant { get; set; }

        /// <summary>
        /// Signup Policy Name. Only applies to AAD B2C Identity Provider.
        /// </summary>
        [JsonPropertyName("signupPolicyName")]
        public string SignupPolicyName { get; set; }

        /// <summary>
        /// Identity Provider Type identifier.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}