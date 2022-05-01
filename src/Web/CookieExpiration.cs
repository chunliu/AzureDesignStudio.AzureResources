using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the session cookie's expiration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class CookieExpiration
    {
        /// <summary>
        /// The convention used when determining the session cookie's expiration.
        /// </summary>
        [JsonPropertyName("convention")]
        public string Convention { get; set; }

        /// <summary>
        /// The time after the request is made when the session cookie should expire.
        /// </summary>
        [JsonPropertyName("timeToExpiration")]
        public string TimeToExpiration { get; set; }
    }
}