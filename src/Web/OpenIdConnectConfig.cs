using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the endpoints used for the custom Open ID Connect provider.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class OpenIdConnectConfig
    {
        /// <summary>
        /// The endpoint to be used to make an authorization request.
        /// </summary>
        [JsonPropertyName("authorizationEndpoint")]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// The endpoint that provides the keys necessary to validate the token.
        /// </summary>
        [JsonPropertyName("certificationUri")]
        public string CertificationUri { get; set; }

        /// <summary>
        /// The endpoint that issues the token.
        /// </summary>
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The endpoint to be used to request a token.
        /// </summary>
        [JsonPropertyName("tokenEndpoint")]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// The endpoint that contains all the configuration endpoints for the provider.
        /// </summary>
        [JsonPropertyName("wellKnownOpenIdConfiguration")]
        public string WellKnownOpenIdConfiguration { get; set; }
    }
}