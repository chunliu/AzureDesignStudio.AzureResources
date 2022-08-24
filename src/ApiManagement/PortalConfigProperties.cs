// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// The developer portal configuration contract properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PortalConfigProperties
    {
        /// <summary>
        /// The developer portal Cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [JsonPropertyName("cors")]
        public PortalConfigCorsProperties Cors { get; set; }

        /// <summary>
        /// The developer portal Content Security Policy (CSP) settings.
        /// </summary>
        [JsonPropertyName("csp")]
        public PortalConfigCspProperties Csp { get; set; }
        [JsonPropertyName("delegation")]
        public PortalConfigDelegationProperties Delegation { get; set; }

        /// <summary>
        /// Enable or disable Basic authentication method.
        /// </summary>
        [JsonPropertyName("enableBasicAuth")]
        public bool EnableBasicAuth { get; set; }
        [JsonPropertyName("signin")]
        public PortalConfigPropertiesSignin Signin { get; set; }
        [JsonPropertyName("signup")]
        public PortalConfigPropertiesSignup Signup { get; set; }
    }
}