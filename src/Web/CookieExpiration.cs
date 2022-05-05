// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the session cookie's expiration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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