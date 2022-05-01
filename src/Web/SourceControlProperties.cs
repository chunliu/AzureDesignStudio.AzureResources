using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// SourceControl resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SourceControlProperties
    {
        /// <summary>
        /// OAuth token expiration.
        /// </summary>
        [JsonPropertyName("expirationTime")]
        public DateTime ExpirationTime { get; set; }

        /// <summary>
        /// OAuth refresh token.
        /// </summary>
        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// OAuth access token.
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }

        /// <summary>
        /// OAuth access token secret.
        /// </summary>
        [JsonPropertyName("tokenSecret")]
        public string TokenSecret { get; set; }
    }
}