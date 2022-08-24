// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// The developer portal Cross-Origin Resource Sharing (CORS) settings.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PortalConfigCorsProperties
    {
        /// <summary>
        /// Allowed origins, e.g. `https://trusted.com`.
        /// </summary>
        [JsonPropertyName("allowedOrigins")]
        public IList<string> AllowedOrigins { get; set; }
    }
}