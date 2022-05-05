// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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