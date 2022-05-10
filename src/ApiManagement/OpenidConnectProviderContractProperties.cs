// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// OpenID Connect Providers Contract.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class OpenidConnectProviderContractProperties
    {
        /// <summary>
        /// Client ID of developer console which is the client application.
        /// </summary>
        [Required]
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Client Secret of developer console which is the client application.
        /// </summary>
        [JsonPropertyName("clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// User-friendly description of OpenID Connect Provider.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// User-friendly OpenID Connect Provider name.
        /// </summary>
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Metadata endpoint URI.
        /// </summary>
        [Required]
        [JsonPropertyName("metadataEndpoint")]
        public string MetadataEndpoint { get; set; }
    }
}