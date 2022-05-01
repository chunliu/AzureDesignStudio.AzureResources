using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the nonce used in the login flow.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Nonce
    {
        /// <summary>
        /// The time after the request is made when the nonce should expire.
        /// </summary>
        [JsonPropertyName("nonceExpirationInterval")]
        public string NonceExpirationInterval { get; set; }

        /// <summary>
        /// <code>false</code> if the nonce should not be validated while completing the login flow; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("validateNonce")]
        public bool ValidateNonce { get; set; }
    }
}