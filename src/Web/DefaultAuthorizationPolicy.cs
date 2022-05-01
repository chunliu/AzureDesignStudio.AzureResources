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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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