// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// The developer portal Content Security Policy (CSP) settings.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PortalConfigCspProperties
    {
        /// <summary>
        /// Allowed sources, e.g. `*.trusted.com`, `trusted.com`, `https://`.
        /// </summary>
        [JsonPropertyName("allowedSources")]
        public IList<string> AllowedSources { get; set; }

        /// <summary>
        /// The mode of the developer portal Content Security Policy (CSP).
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// The URLs used by the browser to report CSP violations.
        /// </summary>
        [JsonPropertyName("reportUri")]
        public IList<string> ReportUri { get; set; }
    }
}