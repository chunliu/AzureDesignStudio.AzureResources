// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Cross-Origin Resource Sharing (CORS) settings for the app.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CorsSettings
    {
        /// <summary>
        /// Gets or sets the list of origins that should be allowed to make cross-origin
        [JsonPropertyName("allowedOrigins")]
        public IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or sets whether CORS requests with credentials are allowed. See 
        [JsonPropertyName("supportCredentials")]
        public bool SupportCredentials { get; set; }
    }
}