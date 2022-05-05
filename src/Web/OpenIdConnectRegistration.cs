// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the app registration for the custom Open ID Connect provider.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class OpenIdConnectRegistration
    {
        /// <summary>
        /// The authentication client credentials of the custom Open ID Connect provider.
        /// </summary>
        [JsonPropertyName("clientCredential")]
        public OpenIdConnectClientCredential ClientCredential { get; set; }

        /// <summary>
        /// The client id of the custom Open ID Connect provider.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// The configuration settings of the endpoints used for the custom Open ID Connect provider.
        /// </summary>
        [JsonPropertyName("openIdConnectConfiguration")]
        public OpenIdConnectConfig OpenIdConnectConfiguration { get; set; }
    }
}