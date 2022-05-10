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
    /// External OAuth authorization server settings Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AuthorizationServerContractProperties
    {
        /// <summary>
        /// OAuth authorization endpoint. See http://tools.ietf.org/html/rfc6749#section-3.2.
        /// </summary>
        [Required]
        [JsonPropertyName("authorizationEndpoint")]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// HTTP verbs supported by the authorization endpoint. GET must be always present. POST is optional.
        /// </summary>
        [JsonPropertyName("authorizationMethods")]
        public IList<string> AuthorizationMethods { get; set; }

        /// <summary>
        /// Specifies the mechanism by which access token is passed to the API. 
        /// </summary>
        [JsonPropertyName("bearerTokenSendingMethods")]
        public IList<string> BearerTokenSendingMethods { get; set; }

        /// <summary>
        /// Method of authentication supported by the token endpoint of this authorization server. Possible values are Basic and/or Body. When Body is specified, client credentials and other parameters are passed within the request body in the application/x-www-form-urlencoded format.
        /// </summary>
        [JsonPropertyName("clientAuthenticationMethod")]
        public IList<string> ClientAuthenticationMethod { get; set; }

        /// <summary>
        /// Client or app id registered with this authorization server.
        /// </summary>
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional reference to a page where client or app registration for this authorization server is performed. Contains absolute URL to entity being referenced.
        /// </summary>
        [Required]
        [JsonPropertyName("clientRegistrationEndpoint")]
        public string ClientRegistrationEndpoint { get; set; }

        /// <summary>
        /// Client or app secret registered with this authorization server. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
        /// </summary>
        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Access token scope that is going to be requested by default. Can be overridden at the API level. Should be provided in the form of a string containing space-delimited values.
        /// </summary>
        [JsonPropertyName("defaultScope")]
        public string DefaultScope { get; set; }

        /// <summary>
        /// Description of the authorization server. Can contain HTML formatting tags.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// User-friendly authorization server name.
        /// </summary>
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Form of an authorization grant, which the client uses to request the access token.
        /// </summary>
        [Required]
        [JsonPropertyName("grantTypes")]
        public IList<string> GrantTypes { get; set; }

        /// <summary>
        /// Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner password.
        /// </summary>
        [JsonPropertyName("resourceOwnerPassword")]
        public string ResourceOwnerPassword { get; set; }

        /// <summary>
        /// Can be optionally specified when resource owner password grant type is supported by this authorization server. Default resource owner username.
        /// </summary>
        [JsonPropertyName("resourceOwnerUsername")]
        public string ResourceOwnerUsername { get; set; }

        /// <summary>
        /// If true, authorization server will include state parameter from the authorization request to its response. Client may use state parameter to raise protocol security.
        /// </summary>
        [JsonPropertyName("supportState")]
        public bool SupportState { get; set; }

        /// <summary>
        /// Additional parameters required by the token endpoint of this authorization server represented as an array of JSON objects with name and value string properties, i.e. {"name" : "name value", "value": "a value"}.
        /// </summary>
        [JsonPropertyName("tokenBodyParameters")]
        public IList<TokenBodyParameterContract> TokenBodyParameters { get; set; }

        /// <summary>
        /// OAuth token endpoint. Contains absolute URI to entity being referenced.
        /// </summary>
        [JsonPropertyName("tokenEndpoint")]
        public string TokenEndpoint { get; set; }
    }
}