// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Azure Active Directory default authorization policy.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DefaultAuthorizationPolicy
    {
        /// <summary>
        /// The configuration settings of the Azure Active Directory allowed applications.
        /// </summary>
        [JsonPropertyName("allowedApplications")]
        public IList<string> AllowedApplications { get; set; }

        /// <summary>
        /// The configuration settings of the Azure Active Directory allowed principals.
        /// </summary>
        [JsonPropertyName("allowedPrincipals")]
        public AllowedPrincipals AllowedPrincipals { get; set; }
    }
}