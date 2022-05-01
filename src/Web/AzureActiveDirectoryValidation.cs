using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Azure Active Directory token validation flow.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureActiveDirectoryValidation
    {
        /// <summary>
        /// The list of audiences that can make successful authentication/authorization requests.
        /// </summary>
        [JsonPropertyName("allowedAudiences")]
        public IList<string> AllowedAudiences { get; set; }

        /// <summary>
        /// The configuration settings of the Azure Active Directory default authorization policy.
        /// </summary>
        [JsonPropertyName("defaultAuthorizationPolicy")]
        public DefaultAuthorizationPolicy DefaultAuthorizationPolicy { get; set; }

        /// <summary>
        /// The configuration settings of the checks that should be made while validating the JWT Claims.
        /// </summary>
        [JsonPropertyName("jwtClaimChecks")]
        public JwtClaimChecks JwtClaimChecks { get; set; }
    }
}