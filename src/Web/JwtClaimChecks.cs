using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the checks that should be made while validating the JWT Claims.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JwtClaimChecks
    {
        /// <summary>
        /// The list of the allowed client applications.
        /// </summary>
        [JsonPropertyName("allowedClientApplications")]
        public IList<string> AllowedClientApplications { get; set; }

        /// <summary>
        /// The list of the allowed groups.
        /// </summary>
        [JsonPropertyName("allowedGroups")]
        public IList<string> AllowedGroups { get; set; }
    }
}